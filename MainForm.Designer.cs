/*
 * Created by SharpDevelop.
 * User: Atin
 * Date: 04-09-2016
 * Time: 00:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Pong
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.SuspendLayout();
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1615, 895);
			this.Name = "MainForm";
			this.Text = "Pong";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClick_1);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_1);
			this.ResumeLayout(false);

		}
	}
}
