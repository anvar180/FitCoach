namespace findgymbro
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Routing.RegisterRoute("ChatPage", typeof(ChatPage));
            Routing.RegisterRoute("MainPage", typeof(MainPage));
            MainPage = new AppShell();
            
        }
    }
}
