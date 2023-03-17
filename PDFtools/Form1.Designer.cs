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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.radioBunpassword = new System.Windows.Forms.RadioButton();
			this.radioBRemoveAtto = new System.Windows.Forms.RadioButton();
			this.comboBoxSelectMode = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(89, 129);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(460, 70);
			this.label1.TabIndex = 0;
			this.label1.Text = "DROP FILE HERE";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label2.Location = new System.Drawing.Point(6, 276);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 25);
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
			this.radioBunpassword.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioBunpassword.Location = new System.Drawing.Point(32, 42);
			this.radioBunpassword.Name = "radioBunpassword";
			this.radioBunpassword.Size = new System.Drawing.Size(106, 29);
			this.radioBunpassword.TabIndex = 2;
			this.radioBunpassword.Text = "Decrypt";
			this.radioBunpassword.UseVisualStyleBackColor = true;
			this.radioBunpassword.CheckedChanged += new System.EventHandler(this.radioBunpassword_CheckedChanged);
			// 
			// radioBRemoveAtto
			// 
			this.radioBRemoveAtto.AutoSize = true;
			this.radioBRemoveAtto.Checked = true;
			this.radioBRemoveAtto.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioBRemoveAtto.Location = new System.Drawing.Point(32, 12);
			this.radioBRemoveAtto.Name = "radioBRemoveAtto";
			this.radioBRemoveAtto.Size = new System.Drawing.Size(212, 29);
			this.radioBRemoveAtto.TabIndex = 3;
			this.radioBRemoveAtto.TabStop = true;
			this.radioBRemoveAtto.Text = "Remove Annotation";
			this.radioBRemoveAtto.UseVisualStyleBackColor = true;
			this.radioBRemoveAtto.CheckedChanged += new System.EventHandler(this.radioBRemoveAtto_CheckedChanged);
			// 
			// comboBoxSelectMode
			// 
			this.comboBoxSelectMode.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxSelectMode.FormattingEnabled = true;
			this.comboBoxSelectMode.Items.AddRange(new object[] {
            "PDFcpu",
            "GhostScript"});
			this.comboBoxSelectMode.Location = new System.Drawing.Point(309, 38);
			this.comboBoxSelectMode.Margin = new System.Windows.Forms.Padding(4);
			this.comboBoxSelectMode.Name = "comboBoxSelectMode";
			this.comboBoxSelectMode.Size = new System.Drawing.Size(180, 33);
			this.comboBoxSelectMode.TabIndex = 4;
			this.comboBoxSelectMode.Text = "PDFcpu";
			this.comboBoxSelectMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectMode_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label3.Location = new System.Drawing.Point(304, 9);
			this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 25);
			this.label3.TabIndex = 5;
			this.label3.Text = "Method";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(644, 310);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBoxSelectMode);
			this.Controls.Add(this.radioBRemoveAtto);
			this.Controls.Add(this.radioBunpassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PDFtools v1.2.0 :: PDF Unlock/Remove Annotation";
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
        private System.Windows.Forms.Label label3;
    }
}

