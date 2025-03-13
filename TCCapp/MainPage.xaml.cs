namespace TCCapp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnEmbarcarClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                Embarcar.Text = $"Clicked {count} time";
            else
                Embarcar.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(Embarcar.Text);
        }

        private void nome_Focused(object sender, FocusEventArgs e)
        {

        }
    }

}
