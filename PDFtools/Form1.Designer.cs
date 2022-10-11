namespace PDFtools
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.radioBunpassword = new System.Windows.Forms.RadioButton();
            this.radioBRemoveAtto = new System.Windows.Forms.RadioButton();
            this.comboBoxSelectMode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "DROP FILE HERE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(319, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "theangkko";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // radioBunpassword
            // 
            this.radioBunpassword.AutoSize = true;
            this.radioBunpassword.Location = new System.Drawing.Point(6, 28);
            this.radioBunpassword.Margin = new System.Windows.Forms.Padding(2);
            this.radioBunpassword.Name = "radioBunpassword";
            this.radioBunpassword.Size = new System.Drawing.Size(66, 16);
            this.radioBunpassword.TabIndex = 2;
            this.radioBunpassword.Text = "Decrypt";
            this.radioBunpassword.UseVisualStyleBackColor = true;
            this.radioBunpassword.CheckedChanged += new System.EventHandler(this.radioBunpassword_CheckedChanged);
            // 
            // radioBRemoveAtto
            // 
            this.radioBRemoveAtto.AutoSize = true;
            this.radioBRemoveAtto.Checked = true;
            this.radioBRemoveAtto.Location = new System.Drawing.Point(6, 6);
            this.radioBRemoveAtto.Margin = new System.Windows.Forms.Padding(2);
            this.radioBRemoveAtto.Name = "radioBRemoveAtto";
            this.radioBRemoveAtto.Size = new System.Drawing.Size(132, 16);
            this.radioBRemoveAtto.TabIndex = 3;
            this.radioBRemoveAtto.TabStop = true;
            this.radioBRemoveAtto.Text = "Remove Annotation";
            this.radioBRemoveAtto.UseVisualStyleBackColor = true;
            this.radioBRemoveAtto.CheckedChanged += new System.EventHandler(this.radioBRemoveAtto_CheckedChanged);
            // 
            // comboBoxSelectMode
            // 
            this.comboBoxSelectMode.FormattingEnabled = true;
            this.comboBoxSelectMode.Items.AddRange(new object[] {
            "GhostScript",
            "PDFcpu"});
            this.comboBoxSelectMode.Location = new System.Drawing.Point(262, 6);
            this.comboBoxSelectMode.Name = "comboBoxSelectMode";
            this.comboBoxSelectMode.Size = new System.Drawing.Size(127, 20);
            this.comboBoxSelectMode.TabIndex = 4;
            this.comboBoxSelectMode.SelectedIndex = 0;
            this.comboBoxSelectMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectMode_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 216);
            this.Controls.Add(this.comboBoxSelectMode);
            this.Controls.Add(this.radioBRemoveAtto);
            this.Controls.Add(this.radioBunpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDFtools v2022:: Unlock/Remove Annot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.RadioButton radioBunpassword;
        private System.Windows.Forms.RadioButton radioBRemoveAtto;
        private System.Windows.Forms.ComboBox comboBoxSelectMode;
    }
}

