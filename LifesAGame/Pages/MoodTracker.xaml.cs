namespace LifesAGame.Pages;

public partial class MoodTracker : ContentPage
{
	public MoodTracker()
	{
		InitializeComponent();
    }
    private void TaskManagerLink_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }

    private void ProfilLink_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Profil());
    }
}