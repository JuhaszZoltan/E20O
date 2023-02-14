namespace ADFGVXgui
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
            this.guiLabel01 = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.checkRichTextBox = new System.Windows.Forms.RichTextBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.guiLabel02 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guiLabel01
            // 
            this.guiLabel01.AutoSize = true;
            this.guiLabel01.Location = new System.Drawing.Point(12, 38);
            this.guiLabel01.Name = "guiLabel01";
            this.guiLabel01.Size = new System.Drawing.Size(140, 15);
            this.guiLabel01.TabIndex = 0;
            this.guiLabel01.Text = "Az ellenőrzés eredménye:";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(132, 12);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(140, 23);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Kódtábla betöltése";
            this.loadButton.UseVisualStyleBackColor = true;
            // 
            // checkRichTextBox
            // 
            this.checkRichTextBox.Location = new System.Drawing.Point(12, 56);
            this.checkRichTextBox.Name = "checkRichTextBox";
            this.checkRichTextBox.Size = new System.Drawing.Size(260, 260);
            this.checkRichTextBox.TabIndex = 2;
            this.checkRichTextBox.Text = "";
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(12, 339);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(260, 260);
            this.mainPanel.TabIndex = 3;
            // 
            // guiLabel02
            // 
            this.guiLabel02.AutoSize = true;
            this.guiLabel02.Location = new System.Drawing.Point(12, 321);
            this.guiLabel02.Name = "guiLabel02";
            this.guiLabel02.Size = new System.Drawing.Size(116, 15);
            this.guiLabel02.TabIndex = 0;
            this.guiLabel02.Text = "A betöltött kódtábla:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 611);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.checkRichTextBox);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.guiLabel02);
            this.Controls.Add(this.guiLabel01);
            this.Name = "MainForm";
            this.Text = "ADFGVX gui";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label guiLabel01;
        private Label guiLabel02;
        private Button loadButton;
        private RichTextBox checkRichTextBox;
        private Panel mainPanel;
    }
}