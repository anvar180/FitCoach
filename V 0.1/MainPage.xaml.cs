using System.Diagnostics;

namespace findgymbro
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

       

        private async void Predpoch(object sender, TappedEventArgs e)
        {
            await DisplayAlert("Предпочтения", "Мощные сыскее!!!", "Ok");
        }

        private async void Age(object sender, TappedEventArgs e)
        {
            await DisplayAlert("Возраст", "Осторожнее, мне только 12", "Ok");
        }

        private void Map(object sender, TappedEventArgs e)
        {
            string Url = "https://yandex.ru/maps/?display-text=%D0%A1%D0%BF%D0%BE%D1%80%D1%82&filter=alternate_vertical%3ARequestWindow&ll=58.881532%2C48.308634&mode=search&sctx=ZAAAAAgBEAAaKAoSCclyEkpf7kNAEfThWYKMokdAEhIJti41Qj9T0j8RoUj3cwryvz8iBgABAgMEBSgKOABAg80GSAFqAnJ1nQHNzEw9oAEAqAEAvQF3UKlfwgEv0unr1tEF45q1mLsEzM7hregFvdu%2B1BC8%2FeTZtpmL%2FWvYpc%2BtHreMrdcE5%2FLplXXqAQDyAQD4AQCCAgrQodC%2F0L7RgNGCigJHMTg0MTA3MzYzJDQxNDMwMDk0MTc1JDE4NDEwNzMxMyQxODQxMDcyOTckMTg0MTA3Mjc1JDE4NDEwNzMxNSQxODQxMDczNjGSAgCaAgxkZXNrdG9wLW1hcHOqAk8yMTE1MDY2NTg1OTUsNzA4MTU5MjcxLDYwMDMxODQsMjE0MTMwNDk3NjY4LDc5NTUzNDMzOTI1LDM4OTk4Nzc5MjcsMTEyOTI1NjIwOTc3&sll=58.881532%2C48.308634&source=serp_navig&sspn=88.386656%2C37.893308&text=%D0%A1%D0%BF%D0%BE%D1%80%D1%82&z=3.73";
            Process.Start("cmd.exe", "/c start " + Url);
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            string Url = "https://youtu.be/dQw4w9WgXcQ?si=V5GO8LssmI5W2nD0";
            Process.Start("cmd.exe", "/c start " + Url);
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("ChatPage");
        }
    }

}
