namespace mail
{
	partial class Form1
	{
		/// <summary>
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Wyczyść wszystkie używane zasoby.
		/// </summary>
		/// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kod generowany przez Projektanta formularzy systemu Windows

		/// <summary>
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
            this.emailLbl = new System.Windows.Forms.Label();
            this.textTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.subjectTxt = new System.Windows.Forms.TextBox();
            this.timesNum = new System.Windows.Forms.NumericUpDown();
            this.sendBtn = new System.Windows.Forms.Button();
            this.amountLbl = new System.Windows.Forms.Label();
            this.SubjectLbl = new System.Windows.Forms.Label();
            this.TextLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timesNum)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(323, 30);
            this.emailLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(38, 13);
            this.emailLbl.TabIndex = 0;
            this.emailLbl.Text = "E-mail:";
            // 
            // textTxt
            // 
            this.textTxt.Location = new System.Drawing.Point(67, 107);
            this.textTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textTxt.Name = "textTxt";
            this.textTxt.Size = new System.Drawing.Size(429, 20);
            this.textTxt.TabIndex = 1;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(361, 28);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(107, 20);
            this.emailTxt.TabIndex = 2;
            // 
            // subjectTxt
            // 
            this.subjectTxt.Location = new System.Drawing.Point(341, 60);
            this.subjectTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subjectTxt.Name = "subjectTxt";
            this.subjectTxt.Size = new System.Drawing.Size(137, 20);
            this.subjectTxt.TabIndex = 3;
            // 
            // timesNum
            // 
            this.timesNum.Location = new System.Drawing.Point(361, 183);
            this.timesNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.timesNum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.timesNum.Name = "timesNum";
            this.timesNum.Size = new System.Drawing.Size(80, 20);
            this.timesNum.TabIndex = 4;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(222, 233);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(74, 41);
            this.sendBtn.TabIndex = 5;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Location = new System.Drawing.Point(311, 184);
            this.amountLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(46, 13);
            this.amountLbl.TabIndex = 6;
            this.amountLbl.Text = "Amount:";
            // 
            // SubjectLbl
            // 
            this.SubjectLbl.AutoSize = true;
            this.SubjectLbl.Location = new System.Drawing.Point(295, 60);
            this.SubjectLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SubjectLbl.Name = "SubjectLbl";
            this.SubjectLbl.Size = new System.Drawing.Size(43, 13);
            this.SubjectLbl.TabIndex = 7;
            this.SubjectLbl.Text = "Subject";
            // 
            // TextLbl
            // 
            this.TextLbl.AutoSize = true;
            this.TextLbl.Location = new System.Drawing.Point(212, 84);
            this.TextLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextLbl.Name = "TextLbl";
            this.TextLbl.Size = new System.Drawing.Size(31, 13);
            this.TextLbl.TabIndex = 8;
            this.TextLbl.Text = "Text:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.TextLbl);
            this.Controls.Add(this.SubjectLbl);
            this.Controls.Add(this.amountLbl);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.timesNum);
            this.Controls.Add(this.subjectTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.textTxt);
            this.Controls.Add(this.emailLbl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "0.0";
            ((System.ComponentModel.ISupportInitialize)(this.timesNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label emailLbl;
		private System.Windows.Forms.TextBox textTxt;
		private System.Windows.Forms.TextBox emailTxt;
		private System.Windows.Forms.TextBox subjectTxt;
		private System.Windows.Forms.NumericUpDown timesNum;
		private System.Windows.Forms.Button sendBtn;
		private System.Windows.Forms.Label amountLbl;
		private System.Windows.Forms.Label SubjectLbl;
		private System.Windows.Forms.Label TextLbl;
	}
}

