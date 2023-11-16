using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ButtonClick(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page1());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page2());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page3());
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page4());
        }

        private async void button4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page5());
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            bool isToggled = e.Value;
            if (isToggled)
            {
                grid.BackgroundColor = Color.White;
                label.TextColor = Color.Black;
                button.BackgroundColor = Color.FromRgb(209, 209, 209); 
                button.TextColor = Color.Black;
                button1.BackgroundColor = Color.FromRgb(219, 219, 219);
                button1.TextColor = Color.Black;
                button2.BackgroundColor = Color.FromRgb(228, 228, 228);
                button2.TextColor = Color.Black;
                button3.BackgroundColor = Color.FromRgb(239, 239, 239);
                button3.TextColor = Color.Black;
                button4.BackgroundColor = Color.FromRgb(199, 199, 199);
                button4.TextColor = Color.Black;
            }
            else
            {
                grid.BackgroundColor = Color.FromRgb(40, 40, 40);
                label.TextColor = Color.White;
                button.BackgroundColor = Color.FromRgb(133, 133, 133);
                button.TextColor = Color.White;
                button1.BackgroundColor = Color.FromRgb(108, 108, 108);
                button1.TextColor = Color.White;
                button2.BackgroundColor = Color.FromRgb(95, 95, 95);
                button2.TextColor = Color.White;
                button3.BackgroundColor = Color.FromRgb(76, 76, 76);
                button3.TextColor = Color.White;
                button4.BackgroundColor = Color.FromRgb(133, 133, 133);
                button4.TextColor = Color.White;
            }
        }
    }
}