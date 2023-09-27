using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestHtmlLabel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            HtmlLabel.Text = "This is <strong style=\"color:red\">HTML</strong> text.";
            HtmlLabel2.Text = "Please verify your Operator registration number <a href=\"https://www.google.com/\" target=\"_blank\">here</a>";
        }
    }
}

