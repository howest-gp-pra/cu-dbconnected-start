﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using Pra.DBConnected.CORE;

namespace Pra.DBConnected.WPF
{
    /// <summary>
    /// Interaction logic for WinUitgevers.xaml
    /// </summary>
    public partial class WinUitgevers : Window
    {
        public WinUitgevers()
        {
            InitializeComponent();
        }
        bool nieuweUitgever;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }
        private void lstUitgevers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void btnNieuw_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnWijzig_Click(object sender, RoutedEventArgs e)
        {
        }
        private void btnAnnuleren_Click(object sender, RoutedEventArgs e)
        {
        }
        private void btnBewaren_Click(object sender, RoutedEventArgs e)
        {
        }
        private void btnVerwijder_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
