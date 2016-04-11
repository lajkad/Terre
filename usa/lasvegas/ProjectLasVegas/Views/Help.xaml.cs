﻿using Core.Shared;
using ProjectLasVegas.Code;
using System;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ProjectLasVegas.Views
{
    public sealed partial class Help : Page
    {
        public Help()
        {
            this.InitializeComponent();
        }
        private void Page1_Click(object sender, RoutedEventArgs e)
        {
            Main.SelectedItem = Page1;
        }

        private void Page2_Click(object sender, RoutedEventArgs e)
        {
            Main.SelectedItem = Page2;
        }

        private void Page3_Click(object sender, RoutedEventArgs e)
        {
            Main.SelectedItem = Page3;
        }

        private void Page4_Click(object sender, RoutedEventArgs e)
        {
            Main.SelectedItem = Page4;
        }

        private void Page5_Click(object sender, RoutedEventArgs e)
        {
            Main.SelectedItem = Page5;
        }

        private void Page6_Click(object sender, RoutedEventArgs e)
        {
            Main.SelectedItem = Page6;
        }
        private void SendFeedback_Click(object sender, RoutedEventArgs e)
        {
            var launched = Launcher.LaunchUriAsync(new Uri("mailto:" + SharedInformation.EmailFeedback));
        }

        private void RateIt_Click(object sender, RoutedEventArgs e)
        {
            RateApp.RateThisApp();
        }

        private void GoToSite_Click(object sender, RoutedEventArgs e)
        {
            var launched = Launcher.LaunchUriAsync(new Uri(SharedInformation.URLSite));
        }
    }
}