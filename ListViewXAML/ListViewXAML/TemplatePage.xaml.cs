using System.Collections.ObjectModel;

namespace ListViewXAML;

public partial class TemplatePage : ContentPage {
	public ObservableCollection<School> Schools { get; private set; }

	public TemplatePage() {
		Schools = new ObservableCollection<School>();
		Schools.Add(new School { Name = "MU", SchoolColor = Colors.Red, School2ndColor = Colors.White, WebsiteURL = "https://www.miamioh.edu" });
		Schools.Add(new School { Name = "OSU", SchoolColor = Colors.Gray, School2ndColor = Colors.Red, WebsiteURL = "https://www.osu.edu" });
		Schools.Add(new School { Name = "UC", SchoolColor = Colors.Red, School2ndColor = Colors.Black, WebsiteURL = "https://www.uc.edu" });
		Schools.Add(new School { Name = "Ohio U", SchoolColor = Colors.Green, School2ndColor = Colors.Black, WebsiteURL = "https://www.ohio.edu" });
		Schools.Add(new School { Name = "BGSU", SchoolColor = Colors.Orange, School2ndColor = Colors.SaddleBrown, WebsiteURL = "https://www.bgsu.edu" });

		InitializeComponent();

		lv.SelectedItem = Schools[0];
		lv.ItemsSource = Schools;
	}
}