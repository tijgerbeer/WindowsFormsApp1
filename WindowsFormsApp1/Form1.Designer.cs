namespace WindowsFormsApp1
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
            this.buttonHello = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonGoodbye = new System.Windows.Forms.Button();
            this.buttonStay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonHello
            // 
            this.buttonHello.BackColor = System.Drawing.Color.Gold;
            this.buttonHello.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonHello.FlatAppearance.BorderSize = 3;
            this.buttonHello.Location = new System.Drawing.Point(41, 39);
            this.buttonHello.Name = "buttonHello";
            this.buttonHello.Size = new System.Drawing.Size(167, 29);
            this.buttonHello.TabIndex = 0;
            this.buttonHello.Text = "Hello";
            this.buttonHello.UseVisualStyleBackColor = false;
            this.buttonHello.Click += new System.EventHandler(this.buttonHello_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 1;
            // 
            // buttonGoodbye
            // 
            this.buttonGoodbye.BackColor = System.Drawing.Color.Red;
            this.buttonGoodbye.Location = new System.Drawing.Point(41, 92);
            this.buttonGoodbye.Name = "buttonGoodbye";
            this.buttonGoodbye.Size = new System.Drawing.Size(167, 27);
            this.buttonGoodbye.TabIndex = 2;
            this.buttonGoodbye.Text = "Goodbye";
            this.buttonGoodbye.UseVisualStyleBackColor = false;
            this.buttonGoodbye.Click += new System.EventHandler(this.buttonGoodbye_Click);
            // 
            // buttonStay
            // 
            this.buttonStay.BackColor = System.Drawing.Color.Green;
            this.buttonStay.Location = new System.Drawing.Point(41, 134);
            this.buttonStay.Name = "buttonStay";
            this.buttonStay.Size = new System.Drawing.Size(167, 27);
            this.buttonStay.TabIndex = 3;
            this.buttonStay.Text = "Stay";
            this.buttonStay.UseVisualStyleBackColor = false;
            this.buttonStay.Click += new System.EventHandler(this.buttonStay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonStay);
            this.Controls.Add(this.buttonGoodbye);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonHello;
		private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonGoodbye;
        private System.Windows.Forms.Button buttonStay;
    }
}

