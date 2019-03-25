namespace جلسه_سوم
{
	public partial class Form1 : System.Windows.Forms.Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, System.EventArgs e)
		{
			//System.Windows.Forms.MessageBox.Show("Hello World!");


			System.Windows.Forms.Button currentButton = sender as System.Windows.Forms.Button;

			if (currentButton != null)
			{
				switch (currentButton.Name)
				{
					case "button1":
						{
							System.Windows.Forms.MessageBox.Show("Hello World1");
							break;
						}

					case "button2":
						{
							System.Windows.Forms.MessageBox.Show("Hello World2");
							break;
						}

					case "button3":
						{
							System.Windows.Forms.MessageBox.Show("Hello World3");
							break;
						}

					case "button4":
						{
							System.Windows.Forms.MessageBox.Show("Hello World4");
							break;
						}

					case "button5":
						{
							System.Windows.Forms.MessageBox.Show("Hello World5");
							break;
						}
				}

			}
		}
	}
}
