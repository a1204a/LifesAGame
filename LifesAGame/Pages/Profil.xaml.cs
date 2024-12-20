namespace LifesAGame.Pages;

public partial class Profil : ContentPage
{
	public Profil()
	{
		InitializeComponent();
	}

    private void GetBack_Clicked(object sender, EventArgs e)
    {
		Navigation.PopModalAsync();
    }

    private void updateProgress_Clicked(object sender, EventArgs e)
    {
        xpBar.Progress += 0.1;

        if (xpBar.Progress == 1)
        {
            updateProgress.IsEnabled = false;
            updateProgress.Text = "You have reached the next level.";
        }
    }
}
