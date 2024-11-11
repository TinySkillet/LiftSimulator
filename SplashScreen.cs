namespace LiftSimGame
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void splash_progressbar_timer_Tick(object sender, EventArgs e)
        {
            splash_loading_bar.Increment(2);
            if (splash_loading_bar.Value >= 100)
            {
                splash_progressbar_timer.Stop();
                this.Hide();
                MainScreen mainScreen = new();
                mainScreen.Show();
            }
        }

    }
}
