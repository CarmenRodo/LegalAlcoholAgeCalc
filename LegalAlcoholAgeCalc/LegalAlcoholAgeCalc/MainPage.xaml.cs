using System;
using Xamarin.Forms;

namespace LegalAlcoholAgeCalc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            double LegalAge = DateTime.Now.Year - DateOfBirth.Date.Year;
            Out_Years.Text = LegalAge.ToString();
            double YearsLeft = LegalAge - 21;
            if (LegalAge >= 21)
            {
                Out_Years.Text = "You Are " + LegalAge + " So you are Legally able to Drink";
            }
            else
            {
                Out_Years.Text = "You Still need " + YearsLeft + " years left  To be able to leaglly drink" ;

            }
        }
    }
}
