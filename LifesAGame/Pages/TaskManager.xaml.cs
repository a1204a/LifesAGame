namespace LifesAGame.Pages;

public partial class TaskManager : ContentPage
{
	public TaskManager()
	{
		InitializeComponent();
	}

    private void MoodTrackerLink_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new MoodTracker());
    }

    private void ProfileLink_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Profil());
    }
}