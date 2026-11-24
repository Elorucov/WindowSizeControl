namespace ELOR.WindowSizeControl
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            windowsList = new ComboBox();
            label1 = new Label();
            winWidth = new Int32TextBox();
            label2 = new Label();
            label3 = new Label();
            winHeight = new Int32TextBox();
            centerAfterResize = new CheckBox();
            label4 = new Label();
            resizeButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // windowsList
            // 
            windowsList.FormattingEnabled = true;
            windowsList.Location = new Point(192, 12);
            windowsList.Name = "windowsList";
            windowsList.Size = new Size(260, 23);
            windowsList.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Location = new Point(12, 16);
            label1.MinimumSize = new Size(92, 0);
            label1.Name = "label1";
            label1.Size = new Size(168, 17);
            label1.TabIndex = 1;
            label1.Text = "Choose window:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // winWidth
            // 
            winWidth.Location = new Point(192, 48);
            winWidth.MaxLength = 4;
            winWidth.Name = "winWidth";
            winWidth.PlaceholderText = "1280";
            winWidth.Size = new Size(64, 23);
            winWidth.TabIndex = 2;
            winWidth.WordWrap = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Location = new Point(12, 51);
            label2.MinimumSize = new Size(92, 0);
            label2.Name = "label2";
            label2.Size = new Size(168, 17);
            label2.TabIndex = 3;
            label2.Text = "Size:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(262, 51);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 4;
            label3.Text = "X";
            // 
            // winHeight
            // 
            winHeight.Location = new Point(282, 48);
            winHeight.MaxLength = 4;
            winHeight.Name = "winHeight";
            winHeight.PlaceholderText = "720";
            winHeight.Size = new Size(64, 23);
            winHeight.TabIndex = 5;
            winHeight.WordWrap = false;
            // 
            // centerAfterResize
            // 
            centerAfterResize.AutoSize = true;
            centerAfterResize.Location = new Point(192, 86);
            centerAfterResize.Name = "centerAfterResize";
            centerAfterResize.Size = new Size(15, 14);
            centerAfterResize.TabIndex = 6;
            centerAfterResize.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.Location = new Point(12, 83);
            label4.MinimumSize = new Size(92, 0);
            label4.Name = "label4";
            label4.Size = new Size(168, 17);
            label4.TabIndex = 7;
            label4.Text = "Move to center of the screen:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // resizeButton
            // 
            resizeButton.Location = new Point(12, 118);
            resizeButton.Margin = new Padding(3, 3, 3, 12);
            resizeButton.Name = "resizeButton";
            resizeButton.Size = new Size(334, 29);
            resizeButton.TabIndex = 8;
            resizeButton.Text = "Resize";
            resizeButton.UseVisualStyleBackColor = true;
            resizeButton.Click += DoResize;
            // 
            // button1
            // 
            button1.Location = new Point(352, 118);
            button1.Name = "button1";
            button1.Size = new Size(100, 29);
            button1.TabIndex = 9;
            button1.Text = "Refresh list";
            button1.UseVisualStyleBackColor = true;
            button1.Click += RefreshList;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(464, 321);
            Controls.Add(button1);
            Controls.Add(resizeButton);
            Controls.Add(label4);
            Controls.Add(centerAfterResize);
            Controls.Add(winHeight);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(winWidth);
            Controls.Add(label1);
            Controls.Add(windowsList);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Window Size Control";
            HelpButtonClicked += ShowHelp;
            Load += OnFormLoad;
            HelpRequested += ShowHelp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox windowsList;
        private Label label1;
        private Int32TextBox winWidth;
        private Label label2;
        private Label label3;
        private Int32TextBox winHeight;
        private CheckBox centerAfterResize;
        private Label label4;
        private Button resizeButton;
        private Button button1;
    }
}
