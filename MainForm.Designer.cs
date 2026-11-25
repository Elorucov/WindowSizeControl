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
            centerOffsetY = new Int32TextBox();
            label5 = new Label();
            label6 = new Label();
            centerOffsetX = new Int32TextBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // windowsList
            // 
            windowsList.FormattingEnabled = true;
            windowsList.Location = new Point(192, 12);
            windowsList.Margin = new Padding(3, 3, 12, 3);
            windowsList.Name = "windowsList";
            windowsList.Size = new Size(260, 23);
            windowsList.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.BackColor = SystemColors.Window;
            label1.Location = new Point(17, 16);
            label1.MinimumSize = new Size(92, 0);
            label1.Name = "label1";
            label1.Size = new Size(168, 17);
            label1.TabIndex = 1;
            label1.Text = "Target window:";
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
            label2.BackColor = SystemColors.Window;
            label2.Location = new Point(17, 51);
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
            label3.BackColor = SystemColors.Window;
            label3.Location = new Point(262, 51);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 4;
            label3.Text = "x";
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
            centerAfterResize.BackColor = SystemColors.Window;
            centerAfterResize.Location = new Point(192, 86);
            centerAfterResize.Name = "centerAfterResize";
            centerAfterResize.Size = new Size(15, 14);
            centerAfterResize.TabIndex = 6;
            centerAfterResize.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.BackColor = SystemColors.Window;
            label4.Location = new Point(17, 83);
            label4.MinimumSize = new Size(92, 0);
            label4.Name = "label4";
            label4.Size = new Size(168, 17);
            label4.TabIndex = 7;
            label4.Text = "Move to center of the screen:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // resizeButton
            // 
            resizeButton.Location = new Point(12, 156);
            resizeButton.Margin = new Padding(3, 3, 3, 10);
            resizeButton.Name = "resizeButton";
            resizeButton.Size = new Size(334, 23);
            resizeButton.TabIndex = 8;
            resizeButton.Text = "Resize";
            resizeButton.UseVisualStyleBackColor = true;
            resizeButton.Click += DoResize;
            // 
            // button1
            // 
            button1.Location = new Point(352, 156);
            button1.Margin = new Padding(3, 3, 12, 3);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 9;
            button1.Text = "Refresh list";
            button1.UseVisualStyleBackColor = true;
            button1.Click += RefreshList;
            // 
            // centerOffsetY
            // 
            centerOffsetY.Location = new Point(282, 112);
            centerOffsetY.MaxLength = 4;
            centerOffsetY.Name = "centerOffsetY";
            centerOffsetY.Size = new Size(64, 23);
            centerOffsetY.TabIndex = 13;
            centerOffsetY.WordWrap = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Window;
            label5.Location = new Point(262, 115);
            label5.Name = "label5";
            label5.Size = new Size(17, 15);
            label5.TabIndex = 12;
            label5.Text = "Y:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.BackColor = SystemColors.Window;
            label6.Location = new Point(17, 115);
            label6.MinimumSize = new Size(92, 0);
            label6.Name = "label6";
            label6.Size = new Size(168, 17);
            label6.TabIndex = 11;
            label6.Text = "Apply offset after centering  X:";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // centerOffsetX
            // 
            centerOffsetX.Location = new Point(192, 112);
            centerOffsetX.Margin = new Padding(3, 3, 3, 12);
            centerOffsetX.MaxLength = 4;
            centerOffsetX.Name = "centerOffsetX";
            centerOffsetX.Size = new Size(64, 23);
            centerOffsetX.TabIndex = 10;
            centerOffsetX.WordWrap = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(centerOffsetY);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(centerOffsetX);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(centerAfterResize);
            panel1.Controls.Add(winHeight);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(winWidth);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(windowsList);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 147);
            panel1.TabIndex = 14;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(464, 321);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(resizeButton);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Int32TextBox centerOffsetY;
        private Label label5;
        private Label label6;
        private Int32TextBox centerOffsetX;
        private Panel panel1;
    }
}
