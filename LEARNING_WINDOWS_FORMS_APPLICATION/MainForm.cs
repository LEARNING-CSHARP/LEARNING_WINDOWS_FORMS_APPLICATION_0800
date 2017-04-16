namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			//BackColor =
			//	System.Drawing.Color.FromArgb
			//	(redHScrollBar.Value, greenHScrollBar.Value, blueHScrollBar.Value);

			redHScrollBar.Value = BackColor.R;
			blueHScrollBar.Value = BackColor.B;
			greenHScrollBar.Value = BackColor.G;
		}

		private void HScrollBar_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			BackColor =
				System.Drawing.Color.FromArgb
				(redHScrollBar.Value, greenHScrollBar.Value, blueHScrollBar.Value);
		}
	}
}
