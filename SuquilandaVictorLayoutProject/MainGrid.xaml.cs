namespace SuquilandaVictorLayoutProject
{
    public partial class MainGrid : ContentPage
    {
        int count = 0;

        public MainGrid()
        {
            InitializeComponent();
        }

        /*
        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
        */

        private void NuevaPagina_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainFlex());
        }
    }

}
