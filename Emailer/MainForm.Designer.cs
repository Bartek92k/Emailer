/*
 * Created by SharpDevelop.
 * User: Barte
 * Date: 21.03.2018
 * Time: 22:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Emailer
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lAdresOdbiorcy;
		private System.Windows.Forms.Label lTemat;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button bWyslij;
		private System.Windows.Forms.TextBox textBox2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.lAdresOdbiorcy = new System.Windows.Forms.Label();
			this.lTemat = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.bWyslij = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(118, 50);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(191, 20);
			this.textBox1.TabIndex = 0;
			// 
			// lAdresOdbiorcy
			// 
			this.lAdresOdbiorcy.Location = new System.Drawing.Point(12, 53);
			this.lAdresOdbiorcy.Name = "lAdresOdbiorcy";
			this.lAdresOdbiorcy.Size = new System.Drawing.Size(100, 23);
			this.lAdresOdbiorcy.TabIndex = 1;
			this.lAdresOdbiorcy.Text = "adres odbiorcy";
			// 
			// lTemat
			// 
			this.lTemat.Location = new System.Drawing.Point(12, 103);
			this.lTemat.Name = "lTemat";
			this.lTemat.Size = new System.Drawing.Size(100, 23);
			this.lTemat.TabIndex = 3;
			this.lTemat.Text = "temat";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(12, 150);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(297, 124);
			this.textBox3.TabIndex = 4;
			// 
			// bWyslij
			// 
			this.bWyslij.Location = new System.Drawing.Point(234, 280);
			this.bWyslij.Name = "bWyslij";
			this.bWyslij.Size = new System.Drawing.Size(75, 23);
			this.bWyslij.TabIndex = 5;
			this.bWyslij.Text = "Wyślij";
			this.bWyslij.UseVisualStyleBackColor = true;
			this.bWyslij.Click += new System.EventHandler(this.BWyslijClick);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(118, 100);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(191, 20);
			this.textBox2.TabIndex = 6;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(342, 542);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.bWyslij);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.lTemat);
			this.Controls.Add(this.lAdresOdbiorcy);
			this.Controls.Add(this.textBox1);
			this.Name = "MainForm";
			this.Text = "Emailer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
