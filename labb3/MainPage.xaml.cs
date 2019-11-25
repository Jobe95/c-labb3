using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace labb3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void doCalcs(double value, double vatValue)
        {
            double finalAmount = value / vatValue;           
            double vatFinal = value - finalAmount;

            amountOutput.Text = value + " SEK";
            double roundedAmount = Math.Round(finalAmount);
            double roundedVat = Math.Round(vatFinal);
            calculatedAmount.Text = roundedAmount.ToString();
            calculatedVat.Text = roundedVat.ToString();
        }

        void buttonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
            if (!string.IsNullOrEmpty(amount.Text))
            {
                double amountValue = double.Parse(amount.Text);
                switch (btn.Text)
                {
                    case "8%":
                        vat.Text = "8%";
                        doCalcs(value: amountValue, vatValue: 1.08);
                        break;
                    case "12%":
                        vat.Text = "12%";
                        doCalcs(value: amountValue, vatValue: 1.12);
                        break;
                    case "25%":
                        vat.Text = "25%";
                        doCalcs(value: amountValue, vatValue: 1.25);
                        break;
                }
            }           
        }
    }
}