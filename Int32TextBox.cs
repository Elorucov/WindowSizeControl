// https://stackoverflow.com/a/12374050

namespace ELOR.WindowSizeControl
{
    public class Int32TextBox : ValidatingTextBox
    {
        protected override void OnTextValidating(object sender, TextValidatingEventArgs e)
        {
            e.Cancel = !int.TryParse(e.NewText, out int i);
        }
    }
}
