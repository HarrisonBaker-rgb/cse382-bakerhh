namespace EventHandlers;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void TheButton_Clicked(object sender, EventArgs e)
	{
		count++;
		theLabel.Text = count.ToString();
	}

	private void TheEntry_TextChanged(object sender, TextChangedEventArgs e)
	{
		theLabel.Text = theEntry.Text;
	}

	private void DigitClicked(object sender, EventArgs e)
	{
		Button button = sender as Button;
		//or Button button = (Button)sender;  // this could throw an exception
		theLabel.Text = button.Text;
	}

	void Slider_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
	{
		sliderLabel.Text = theSlider.Value.ToString();
	}

	void entryChanged(object sender, TextChangedEventArgs e)
	{
		entryLabel.Text = newEntry.Text.Length.ToString();
	}

	int buttonCount = 0;
	private void OnClicked(object sender, EventArgs e)
	{
		buttonCount++;
		buttonLabel.Text = buttonCount.ToString();
	}

	private void OnChecked(object sender, CheckedChangedEventArgs e)
	{
		if (checkBox.IsChecked == false)
		{
			checkBoxLabel.Text = "Unchecked";

		}
		else
		{
			checkBoxLabel.Text = "Checked";
		}
	}
	private void OnToggled(object sender, ToggledEventArgs e)
	{
		if (theSwitch.IsToggled == false)
		{
			switchLabel.Text = "Unchecked";

		}
		else
		{
			switchLabel.Text = "Checked";
		}
	}
	private void OnStepValueChanged(object sender, ValueChangedEventArgs e)
	{
		stepperLabel.Text = theStepper.Value.ToString();
	}

	private void thePicker_SelectedIndexChanged(object sender, EventArgs e)
	{
		int index = thePicker.SelectedIndex;
		if (thePicker.SelectedIndex == 0)
		{
			pickerLabel.Text = "Blue";
            pickerLabel.TextColor = Colors.Blue;
        } else if (thePicker.SelectedIndex == 1)
		{
            pickerLabel.Text = "Red";
			pickerLabel.TextColor = Colors.Red;
        } else
		{
            pickerLabel.Text = "Green";
			pickerLabel.TextColor = Colors.Green;
        }
	}
}
