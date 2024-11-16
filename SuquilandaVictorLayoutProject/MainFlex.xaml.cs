namespace SuquilandaVictorLayoutProject;

public partial class MainFlex : ContentPage
{
	public MainFlex()
	{
		InitializeComponent();
	}

    private void NuevaPagina_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainAbsLayout());
    }
}