using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Week1Challenge
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public int No_OfClicks;
        public MainPage()
        {
            InitializeComponent();
        }

        private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            label.FontSize = e.NewValue;
        }


          int count = 0; 
        
        void Button_Clicked(object sender, System.EventArgs e) { 
          count++;

            if (count == 1)
            {
                label.Text = "Life is like a bicycle to keep your balance you must keep moving";
            }
            else if (count == 2)
            {
                label.Text = "Look deep into nature then you will Understand Everything better";
            }
            else if (count == 3)
            {
                label.Text = "You cant blame gravity for falling in love";
                count = 0;
            }




        }





    }

}


    

        
   
