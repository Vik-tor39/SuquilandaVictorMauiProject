namespace SuquilandaVictorLayoutProject;

public partial class MainAbsLayout : ContentPage
{
	public MainAbsLayout()
	{
		InitializeComponent();
	}
    void OnScrollViewScrolled(object sender, ScrolledEventArgs e)
    {
        Console.WriteLine($"ScrollX: {e.ScrollX}, ScrollY: {e.ScrollY}");
    }
    private void NuevaPagina_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainGrid());
    }
}