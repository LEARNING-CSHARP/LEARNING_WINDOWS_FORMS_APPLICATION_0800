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
			// Solution (1)
			BackColor =
				System.Drawing.Color.FromArgb
				(red: redHScrollBar.Value, green: greenHScrollBar.Value, blue: blueHScrollBar.Value);
			// /Solution (1)

			// Solution (2)
			//redHScrollBar.Value = BackColor.R;
			//blueHScrollBar.Value = BackColor.B;
			//greenHScrollBar.Value = BackColor.G;
			// /Solution (2)
		}

		private void HScrollBar_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			BackColor =
				System.Drawing.Color.FromArgb
				(red: redHScrollBar.Value, green: greenHScrollBar.Value, blue: blueHScrollBar.Value);
		}
	}
}
