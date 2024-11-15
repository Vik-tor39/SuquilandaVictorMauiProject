namespace SuquilandaVictorLayoutProject;

public partial class MainFlex : ContentPage
{
	public MainFlex()
	{
		InitializeComponent();
	}
	private void Boton2_Clicked(object sender , EventArgs e)
	{
		Navigation.PopAsync();
	}
}