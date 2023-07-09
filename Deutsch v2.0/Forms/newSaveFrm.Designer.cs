namespace Deutsch_v2._0.Forms
{
    partial class newSaveFrm
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.toLbl = new System.Windows.Forms.Label();
            this.fromLbl = new System.Windows.Forms.Label();
            this.langCmb = new System.Windows.Forms.ComboBox();
            this.toTxtbox = new System.Windows.Forms.TextBox();
            this.fromTxtbox = new System.Windows.Forms.TextBox();
            this.pathTxtBox = new System.Windows.Forms.TextBox();
            this.saveTxtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(583, 376);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // toLbl
            // 
            this.toLbl.AutoSize = true;
            this.toLbl.Location = new System.Drawing.Point(321, 196);
            this.toLbl.Name = "toLbl";
            this.toLbl.Size = new System.Drawing.Size(19, 15);
            this.toLbl.TabIndex = 10;
            this.toLbl.Text = "To";
            // 
            // fromLbl
            // 
            this.fromLbl.AutoSize = true;
            this.fromLbl.Location = new System.Drawing.Point(142, 196);
            this.fromLbl.Name = "fromLbl";
            this.fromLbl.Size = new System.Drawing.Size(35, 15);
            this.fromLbl.TabIndex = 11;
            this.fromLbl.Text = "From";
            // 
            // langCmb
            // 
            this.langCmb.FormattingEnabled = true;
            this.langCmb.Items.AddRange(new object[] {
            "German To English"});
            this.langCmb.Location = new System.Drawing.Point(142, 93);
            this.langCmb.Name = "langCmb";
            this.langCmb.Size = new System.Drawing.Size(410, 23);
            this.langCmb.TabIndex = 9;
            // 
            // toTxtbox
            // 
            this.toTxtbox.Location = new System.Drawing.Point(365, 193);
            this.toTxtbox.Name = "toTxtbox";
            this.toTxtbox.Size = new System.Drawing.Size(97, 23);
            this.toTxtbox.TabIndex = 5;
            this.toTxtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toTxtbox_KeyDown);
            // 
            // fromTxtbox
            // 
            this.fromTxtbox.Location = new System.Drawing.Point(200, 196);
            this.fromTxtbox.Name = "fromTxtbox";
            this.fromTxtbox.Size = new System.Drawing.Size(97, 23);
            this.fromTxtbox.TabIndex = 6;
            this.fromTxtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fromTxtbox_KeyDown);
            // 
            // pathTxtBox
            // 
            this.pathTxtBox.Location = new System.Drawing.Point(142, 144);
            this.pathTxtBox.Name = "pathTxtBox";
            this.pathTxtBox.Size = new System.Drawing.Size(410, 23);
            this.pathTxtBox.TabIndex = 7;
            this.pathTxtBox.Text = "file name";
            this.pathTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pathTxtBox_KeyDown);
            // 
            // saveTxtbox
            // 
            this.saveTxtbox.Location = new System.Drawing.Point(142, 52);
            this.saveTxtbox.Name = "saveTxtbox";
            this.saveTxtbox.Size = new System.Drawing.Size(410, 23);
            this.saveTxtbox.TabIndex = 8;
            this.saveTxtbox.Text = "preset name";
            this.saveTxtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.saveTxtbox_KeyDown);
            // 
            // newSaveFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.toLbl);
            this.Controls.Add(this.fromLbl);
            this.Controls.Add(this.langCmb);
            this.Controls.Add(this.toTxtbox);
            this.Controls.Add(this.fromTxtbox);
            this.Controls.Add(this.pathTxtBox);
            this.Controls.Add(this.saveTxtbox);
            this.Name = "newSaveFrm";
            this.Text = "newSaveFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button saveBtn;
        private Label toLbl;
        private Label fromLbl;
        private ComboBox langCmb;
        private TextBox toTxtbox;
        private TextBox fromTxtbox;
        private TextBox pathTxtBox;
        private TextBox saveTxtbox;
    }
}