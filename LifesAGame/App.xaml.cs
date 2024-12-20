using LifesAGame.Pages;

namespace LivesAGame
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TaskManager();
        }
    }
}