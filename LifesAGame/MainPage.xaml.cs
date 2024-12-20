namespace LivesAGame
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TaskManagerLink_Clicked(object sender, EventArgs e)
        {
            TaskManagerLink.Text = "Was clicked";

        }

    }

}