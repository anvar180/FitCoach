namespace findgymbro;

public partial class ChatPage : ContentPage
{
	public ChatPage()
	{
		InitializeComponent();
	}

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///MainPage");
    }
}