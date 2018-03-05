namespace LoginForm
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
			this.buttonLog = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxUser = new System.Windows.Forms.TextBox();
			this.textBoxPass = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// buttonLog
			// 
			this.buttonLog.DialogResult = System.Windows.Forms.DialogResult.No;
			this.buttonLog.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLog.ForeColor = System.Drawing.Color.Black;
			this.buttonLog.Location = new System.Drawing.Point(201, 203);
			this.buttonLog.Name = "buttonLog";
			this.buttonLog.Size = new System.Drawing.Size(133, 45);
			this.buttonLog.TabIndex = 0;
			this.buttonLog.Text = "Log In";
			this.buttonLog.UseVisualStyleBackColor = true;
			this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(49, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 27);
			this.label1.TabIndex = 1;
			this.label1.Text = "User Name:\r\n";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// textBoxUser
			// 
			this.textBoxUser.Location = new System.Drawing.Point(201, 35);
			this.textBoxUser.Name = "textBoxUser";
			this.textBoxUser.Size = new System.Drawing.Size(133, 26);
			this.textBoxUser.TabIndex = 2;
			// 
			// textBoxPass
			// 
			this.textBoxPass.Location = new System.Drawing.Point(201, 95);
			this.textBoxPass.Name = "textBoxPass";
			this.textBoxPass.Size = new System.Drawing.Size(133, 26);
			this.textBoxPass.TabIndex = 3;
			this.textBoxPass.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(49, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 27);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(201, 144);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(148, 24);
			this.checkBox1.TabIndex = 5;
			this.checkBox1.Text = "Show Password";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(505, 291);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxPass);
			this.Controls.Add(this.textBoxUser);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonLog);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonLog;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxUser;
		private System.Windows.Forms.TextBox textBoxPass;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBox1;
	}
}

