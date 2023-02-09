using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinMobileApp
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        Label label;
        int nr1;
        int nr2;
        string symbol;
        bool isFirstClick = true;
        public MainPage()
        {
            InitializeComponent();
            label = this.FindByName<Label>("text");
        }

        void HandleClickOnNumber (object sender, EventArgs e)
        {
            string num = (sender as Button).Text;
            label.Text += " " + num;
            if (isFirstClick)
            {
                isFirstClick = false;
                nr1 = int.Parse(num);
            }
            else
            {
                nr2 = int.Parse(num);
            }
        }

        void HandleClickOnSymbol(object sender, EventArgs e)
        {
            string sign = (sender as Button).Text;
            symbol = sign;
            label.Text += " " + sign;
        }

        void HandleClickOnClear(object sender, EventArgs e)
        {
            isFirstClick = true;
            label.Text += "";
        }

        void HandleClickOnEquals(object sender, EventArgs e)
        {
            int result = 0;
            switch (symbol)
            {
                case "+":
                    result = nr1 + nr2;
                    break;
                case "-":
                    result = nr1 - nr2;
                    break;
                case "*":
                    result = nr1 * nr2;
                    break;
                case "/":
                    result = nr1 / nr2;
                    break;

            }
            label.Text += "=" + result.ToString();
        }
    }
}
