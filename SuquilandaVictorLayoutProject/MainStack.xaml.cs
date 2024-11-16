namespace SuquilandaVictorLayoutProject;

public partial class MainStack : ContentPage
{
	public MainStack()
	{
		InitializeComponent();
	}
	private void Boton2_Clicked(object sender , EventArgs e)
	{
		Navigation.PushAsync(new MainFlex());
	}
}