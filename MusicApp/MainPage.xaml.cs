namespace MusicApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void musicPage_Button(object? sender, EventArgs e)
        {
            Application.Current.MainPage = new music_page();
        }
        
    }
}
