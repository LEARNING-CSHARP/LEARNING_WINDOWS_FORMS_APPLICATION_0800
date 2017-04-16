namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

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
			this.redHScrollBar = new System.Windows.Forms.HScrollBar();
			this.greenHScrollBar = new System.Windows.Forms.HScrollBar();
			this.blueHScrollBar = new System.Windows.Forms.HScrollBar();
			this.SuspendLayout();
			// 
			// redHScrollBar
			// 
			this.redHScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.redHScrollBar.Location = new System.Drawing.Point(9, 9);
			this.redHScrollBar.Maximum = 255;
			this.redHScrollBar.Name = "redHScrollBar";
			this.redHScrollBar.Size = new System.Drawing.Size(361, 17);
			this.redHScrollBar.TabIndex = 0;
			this.redHScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBar_Scroll);
			// 
			// greenHScrollBar
			// 
			this.greenHScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.greenHScrollBar.Location = new System.Drawing.Point(9, 26);
			this.greenHScrollBar.Maximum = 255;
			this.greenHScrollBar.Name = "greenHScrollBar";
			this.greenHScrollBar.Size = new System.Drawing.Size(361, 17);
			this.greenHScrollBar.TabIndex = 1;
			this.greenHScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBar_Scroll);
			// 
			// blueHScrollBar
			// 
			this.blueHScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.blueHScrollBar.Location = new System.Drawing.Point(9, 43);
			this.blueHScrollBar.Maximum = 255;
			this.blueHScrollBar.Name = "blueHScrollBar";
			this.blueHScrollBar.Size = new System.Drawing.Size(361, 17);
			this.blueHScrollBar.TabIndex = 2;
			this.blueHScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBar_Scroll);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(379, 131);
			this.Controls.Add(this.blueHScrollBar);
			this.Controls.Add(this.greenHScrollBar);
			this.Controls.Add(this.redHScrollBar);
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.HScrollBar redHScrollBar;
		private System.Windows.Forms.HScrollBar greenHScrollBar;
		private System.Windows.Forms.HScrollBar blueHScrollBar;

	}
}
