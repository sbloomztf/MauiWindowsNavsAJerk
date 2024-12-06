namespace MauiWindowsNavsAJerk
{
    public partial class NotMainPage : ContentPage
    {
        int count = 0;

        public NotMainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());

            /*

            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);*/
        }
    }

}
