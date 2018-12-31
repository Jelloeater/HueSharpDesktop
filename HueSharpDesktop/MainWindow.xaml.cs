﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace HueSharpDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            var LightList = libs.Lights.GetLightList;
            for (int i = 0; i < 5; i++)
            {


                System.Windows.Controls.Button newBtn = new Button();

                newBtn.Content = i.ToString();
                newBtn.Name = "Button" + i.ToString();

                mainSubPannel.Children.Add(newBtn);

            }
        }
    }
}
