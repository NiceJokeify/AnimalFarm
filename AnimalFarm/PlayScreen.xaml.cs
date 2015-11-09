using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;


namespace AnimalFarm
{
    public partial class PlayScreen : PhoneApplicationPage
    {
        String text = "";

        public PlayScreen()
        {
            InitializeComponent();
        }

        private void horse_Click(object sender, RoutedEventArgs e)
        {
            text = "This is a Horse";
            displayTxt.Text = text;
            horseSound.Play();
        }

        private void chicken_Click(object sender, RoutedEventArgs e)
        {
            text = "This is a Chicken";
            displayTxt.Text = text;
            chickenSound.Play();
        }

        private void cow_Click(object sender, RoutedEventArgs e)
        {
            text = "This is a Cow";
            displayTxt.Text = text;
            cowSound.Play();
        }

        private void pig_Click(object sender, RoutedEventArgs e)
        {
            text = "This is a Pig";
            displayTxt.Text = text;
            pigSound.Play();
        }

        private void fox_Click(object sender, RoutedEventArgs e)
        {
            text = "This is a Fox";
            displayTxt.Text = text;
            foxsound.Play();
        }

        private void barn_Click(object sender, RoutedEventArgs e)
        {
            //Activate for extra fun
            /*text = "420 erryday";
            displayTxt.Text = text;
            
            erryday.Play();*/
        }
    }
}