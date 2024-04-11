using System.Security.Cryptography.X509Certificates;
using System;

namespace Provinha
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            PickerDice.SelectedIndex = 0;
        }

        private void RollDice_Clicked(object sender, EventArgs e) 
        {
            int selected = Convert.ToInt32(PickerDice.SelectedIndex);
            int tipo = Convert.ToInt32(PickerDice.Items[selected]);
            Random random = new Random();
            int aleatorio = random.Next(tipo);
            while(aleatorio == 0)
            {
                aleatorio = random.Next(tipo);
            }
            LabelDice.Text = aleatorio.ToString();
        }

}

}
