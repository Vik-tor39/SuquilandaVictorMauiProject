namespace SuquilandaVictorLayoutProject;

public partial class MainAbsLayout : ContentPage
{
	public MainAbsLayout()
	{
		InitializeComponent();
	}
    private void NuevaPagina_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainGrid());
    }
}