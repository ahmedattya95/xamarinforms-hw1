using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Homework1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Set the images from resources 
            coverImage.Source = ImageSource.FromResource("Homework1.Images.hero.jpg");
            profileImage.Source = ImageSource.FromResource("Homework1.Images.employee.jpg"); 
        }
    }
}
