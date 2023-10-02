namespace GridXAML;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

	void Button_Clicked(System.Object sender, System.EventArgs e)
	{
		Button b = sender as Button;
		if (b.Text != "Clear")
		{
			if (b.Text == "0" && theLabel.Text=="")
			{  
            } else
			{
                theLabel.Text += b.Text;
            }
        } else
		{
			theLabel.Text = "";
		}
		 
	}
}
