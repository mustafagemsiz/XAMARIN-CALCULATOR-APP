using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinCalculator
{
    public partial class MainPage : ContentPage
    {
        string islem="";
        double sayi1;
        public MainPage()
        {
            InitializeComponent();
        }

        void temizle(Object sender,EventArgs e)
        {
            LblSonuc.Text = "";
            islem = "";
        }        
        void islemsec(Object sender,EventArgs e)
        {
            Button bt = (Button)sender;
            islem = bt.Text;
            sayi1 = Convert.ToDouble(LblSonuc.Text);
            LblSonuc.Text = "";
        }

        void yuzde(Object sender, EventArgs e)
        {

        }

        void karekok(Object sender, EventArgs e)
        {

        }

        void sayi(Object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            LblSonuc.Text = LblSonuc.Text + bt.Text;
        }

        void hesapla(Object sender, EventArgs e)
        {

        }
    }
}
