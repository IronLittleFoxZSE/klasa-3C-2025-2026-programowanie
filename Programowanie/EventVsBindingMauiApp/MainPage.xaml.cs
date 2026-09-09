
namespace EventVsBindingMauiApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            /*Slider slider = sender as Slider;
            if (rotationLabel is not null
                && slider is not null)*/
            //Slider slider = sender as Slider;
            if (rotationLabel is not null
                && sender is Slider slider)
            {
                rotationLabel.Rotation = slider.Value;
                rotationLabel.Text = slider.Value.ToString();
            }
        }
    }
}
