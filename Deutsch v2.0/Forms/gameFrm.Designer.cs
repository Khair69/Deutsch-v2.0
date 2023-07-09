namespace Deutsch_v2._0.Forms
{
    partial class gameFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gameProg = new ProgressBar();
            resLbl = new Label();
            checkBtn = new Button();
            cnBtn = new Button();
            ansTxtbox = new TextBox();
            dWordLbl = new Label();
            SuspendLayout();
            // 
            // gameProg
            // 
            gameProg.Location = new Point(80, 53);
            gameProg.Name = "gameProg";
            gameProg.Size = new Size(641, 23);
            gameProg.TabIndex = 11;
            // 
            // resLbl
            // 
            resLbl.AutoSize = true;
            resLbl.Location = new Point(267, 375);
            resLbl.Name = "resLbl";
            resLbl.Size = new Size(0, 15);
            resLbl.TabIndex = 10;
            resLbl.Visible = false;
            // 
            // checkBtn
            // 
            checkBtn.Enabled = false;
            checkBtn.Location = new Point(609, 375);
            checkBtn.Name = "checkBtn";
            checkBtn.Size = new Size(75, 23);
            checkBtn.TabIndex = 8;
            checkBtn.Text = "Check";
            checkBtn.UseVisualStyleBackColor = true;
            checkBtn.Click += checkBtn_Click;
            // 
            // cnBtn
            // 
            cnBtn.Location = new Point(609, 375);
            cnBtn.Name = "cnBtn";
            cnBtn.Size = new Size(75, 23);
            cnBtn.TabIndex = 9;
            cnBtn.Text = "Continue";
            cnBtn.UseVisualStyleBackColor = true;
            cnBtn.Visible = false;
            cnBtn.Click += cnBtn_Click;
            // 
            // ansTxtbox
            // 
            ansTxtbox.Location = new Point(254, 206);
            ansTxtbox.Name = "ansTxtbox";
            ansTxtbox.Size = new Size(348, 23);
            ansTxtbox.TabIndex = 12;
            ansTxtbox.TextChanged += ansTxtbox_TextChanged;
            ansTxtbox.KeyDown += ansTxtbox_KeyDown;
            // 
            // dWordLbl
            // 
            dWordLbl.AutoSize = true;
            dWordLbl.Location = new Point(383, 174);
            dWordLbl.Name = "dWordLbl";
            dWordLbl.Size = new Size(82, 15);
            dWordLbl.TabIndex = 13;
            dWordLbl.Text = "Duetsch Word";
            // 
            // gameFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(dWordLbl);
            Controls.Add(ansTxtbox);
            Controls.Add(gameProg);
            Controls.Add(resLbl);
            Controls.Add(checkBtn);
            Controls.Add(cnBtn);
            MaximumSize = new Size(1920, 1032);
            Name = "gameFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "gameFrm";
            TransparencyKey = Color.Fuchsia;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar gameProg;
        private Label resLbl;
        private Button checkBtn;
        private Button cnBtn;
        private TextBox ansTxtbox;
        private Label dWordLbl;
    }
}