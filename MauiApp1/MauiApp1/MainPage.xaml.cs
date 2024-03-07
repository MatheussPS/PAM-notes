namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        //private void OnCounterClicked(object sender, EventArgs e)
        //{
        //    count++;

        //    if (count == 1)
        //        CounterBtn.Text = $"Clicked {count} time";
        //    else
        //        CounterBtn.Text = $"Clicked {count} times";

        //    SemanticScreenReader.Announce(CounterBtn.Text);
        //}

        private void ExibirNomeClicked(object sender, EventArgs e)
        {
            String name = NameEntry.Text;
            SaidaNome.Text = $"Olá, {name}";
        }

        private void ExibirSomaClicked(object sender, EventArgs e)
        {
            int n1 = Int32.Parse(FirstNumberEntry.Text);
            int n2 = Int32.Parse(SecondNumberEntry.Text);
            int soma = n1 + n2;
            SomaExibe.Text = $"A soma dos números digitaos é {soma}";

        }

        private async void GuideAbout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());

        }
    }
}

