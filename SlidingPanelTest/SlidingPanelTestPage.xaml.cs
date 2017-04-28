using DK.SlidingPanel.Interface;
using ReactiveUI;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace SlidingPanelTest
{
    public partial class SlidingPanelTestPage : ContentPage
    {
        async void Handle_Tapped(object sender, System.EventArgs e)
        {
            var initialPosition = Main.Height;
            var currentPosition = body.Height;

            await body.TranslateTo(0, (initialPosition - currentPosition) * -1, 500, Easing.SinIn);
        }

        public SlidingPanelTestPage()
        {
            InitializeComponent();

            body.TranslationY = Main.Height + 400;
        }
    }
}
