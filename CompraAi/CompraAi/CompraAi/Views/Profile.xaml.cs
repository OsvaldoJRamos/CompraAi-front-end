
using Xamarin.Forms;
using System;
namespace CompraAi.Views
{
    public partial class Profile : ContentPage
    {
        public Profile(string message)
        {
            InitializeComponent();
            this.lblMessage.Text = message;

        }
    }
}