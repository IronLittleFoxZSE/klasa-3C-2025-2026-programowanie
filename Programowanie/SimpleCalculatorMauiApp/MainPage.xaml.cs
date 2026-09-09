namespace SimpleCalculatorMauiApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //pobrać dane wejściowe
            //var firstNumber = int.Parse(firstNumberEntry.Text);
            //int firstNumber;
            if (int.TryParse(firstNumberEntry.Text, out int firstNumber)
                && int.TryParse(secondNumberEntry.Text, out int secondNumber))
            {
                //wykonać operację dodawania
                //wyświetlić wynik
                resultLabel.Text = $"Wynik dodawania to {firstNumber + secondNumber}";
                resultLabel.BackgroundColor = Colors.Green;
            }
            else
            {
                resultLabel.Text = $"Podałeś nieprawidłowe dane.";
                resultLabel.BackgroundColor = Colors.Red;
            }

        }
    }
}
