using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace ELOR.WindowSizeControl
{
    public partial class MainForm : Form
    {
        private sealed record WindowItem(IntPtr Handle, string Title)
        {
            public override string ToString() => Title;
        }


        public MainForm()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            windowsList.DropDownStyle = ComboBoxStyle.DropDownList;
            windowsList.SelectedIndexChanged -= OnWindowSelected;
            windowsList.SelectedIndexChanged += OnWindowSelected;

            RefreshWindowList();
        }

        private void RefreshWindowList()
        {
            windowsList.BeginUpdate();
            try
            {
                windowsList.Items.Clear();

                foreach (var item in EnumerateResizableWindows())
                    windowsList.Items.Add(item);

                if (windowsList.Items.Count > 0)
                    windowsList.SelectedIndex = 0;
            }
            finally
            {
                windowsList.EndUpdate();
            }
        }

        // Set selected window's size in boxes
        private void OnWindowSelected(object sender, EventArgs e)
        {
            if (windowsList.SelectedItem is WindowItem item &&
                Win32API.GetWindowRect(item.Handle, out Win32API.RECT rect))
            {
                winWidth.Text = rect.Width.ToString();
                winHeight.Text = rect.Height.ToString();
            }
        }

        private IEnumerable<WindowItem> EnumerateResizableWindows()
        {
            var result = new List<WindowItem>();
            IntPtr ownHandle = this.Handle;

            Win32API.EnumWindows((hWnd, _) =>
            {
                if (hWnd == ownHandle || !Win32API.IsWindowVisible(hWnd))
                    return true;

                // Only top-level windows without parent
                if (Win32API.GetWindow(hWnd, Win32API.GW_OWNER) != IntPtr.Zero)
                    return true;

                int style = Win32API.GetWindowLongW(hWnd, Win32API.GWL_STYLE);
                int exStyle = Win32API.GetWindowLongW(hWnd, Win32API.GWL_EXSTYLE);

                if ((style & Win32API.WS_THICKFRAME) == 0)
                    return true;

                // Skip tool windows
                if ((exStyle & Win32API.WS_EX_TOOLWINDOW) != 0 && (exStyle & Win32API.WS_EX_APPWINDOW) == 0)
                    return true;

                // Skip hidden windows
                if (Win32API.DwmGetWindowAttribute(hWnd, Win32API.DWMWA_CLOAKED, out int cloaked, sizeof(int)) == 0 && cloaked != 0)
                    return true;

                int length = Win32API.GetWindowTextLengthW(hWnd);
                if (length == 0)
                    return true;

                var sb = new StringBuilder(length + 1);
                Win32API.GetWindowTextW(hWnd, sb, sb.Capacity);
                string title = sb.ToString();

                if (!string.IsNullOrWhiteSpace(title)) result.Add(new WindowItem(hWnd, title));

                return true;
            }, IntPtr.Zero);

            return result.OrderBy(w => w.Title, StringComparer.CurrentCultureIgnoreCase);
        }

        private void DoResize(object sender, EventArgs e)
        {
            if (windowsList.SelectedItem is not WindowItem item)
            {
                MessageBox.Show(this, "Select window first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // We using Int32TextBox, but users CAN insert non-number symbols from clipboard!
            if (!int.TryParse(winWidth.Text, out int width) || width <= 0 ||
                !int.TryParse(winHeight.Text, out int height) || height <= 0)
            {
                MessageBox.Show(this, "Invalid width or height.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            IntPtr hWnd = item.Handle;

            if (!Win32API.IsWindow(hWnd))
            {
                MessageBox.Show(this, "Cannot check selected window. Windows list will be refreshed.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RefreshWindowList();
                return;
            }

            // Restoring minimized and maximized window
            if (Win32API.IsIconic(hWnd) || Win32API.IsZoomed(hWnd))
                Win32API.ShowWindow(hWnd, Win32API.SW_RESTORE);

            uint flags = Win32API.SWP_NOZORDER | Win32API.SWP_NOACTIVATE;
            int x = 0, y = 0;

            if (centerAfterResize.Checked)
            {
                int.TryParse(centerOffsetX.Text, out int offsetX);
                int.TryParse(centerOffsetY.Text, out int offsetY);

                Rectangle area = Screen.FromHandle(hWnd).WorkingArea;
                x = (area.Left + (area.Width - width) / 2) + offsetX;
                y = (area.Top + (area.Height - height) / 2) + offsetY;
            }
            else
            {
                flags |= Win32API.SWP_NOMOVE;
            }

            if (!Win32API.SetWindowPos(hWnd, IntPtr.Zero, x, y, width, height, flags))
            {
                var ex = new Win32Exception(Marshal.GetLastWin32Error());
                MessageBox.Show(this,
                    $"Failed to resize window: {ex.Message}\n\n" +
                    "Please note: if the window is running with admin privileges, launch this program as admin as well.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshList(object sender, EventArgs e)
        {
            RefreshWindowList();
        }

        private void ShowHelp(object sender, HelpEventArgs hlpevent)
        {
            ShowHelp();
            hlpevent.Handled = true;
        }

        private void ShowHelp(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            ShowHelp();
        }

        private void ShowHelp()
        {
            var processPath = Environment.ProcessPath;
            var fileVersion = processPath is not null
                ? FileVersionInfo.GetVersionInfo(processPath).FileVersion
                : "N/A";

            StringBuilder text = new StringBuilder();
            text.AppendLine($"Created by Elchin Orujov. Version {fileVersion}");
            text.AppendLine();
            text.AppendLine("The program lets you to resize windows and center them as you see fit.");
            text.AppendLine("The list includes only those windows that can be resized. If a selected window is minimized, it will be restored.");
            text.AppendLine();
            text.AppendLine("You can also have the window centered on the screen after its size is changed by selecting the \"Move to center of the screen\" checkbox. If you would like the window to be shifted by a specific distance after being centered, enter that distance in the \"Apply offset after centering\" fields.");

            MessageBox.Show(this, text.ToString(), "Help & About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
