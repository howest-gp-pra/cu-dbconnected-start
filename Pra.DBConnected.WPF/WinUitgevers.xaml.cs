using System;
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
        bool nieuweUitgever;

        public WinUitgevers()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }
        private void LstUitgevers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void BtnNieuw_Click(object sender, RoutedEventArgs e)
        {
        }

        private void BtnWijzig_Click(object sender, RoutedEventArgs e)
        {
        }
        private void BtnAnnuleren_Click(object sender, RoutedEventArgs e)
        {
        }
        private void BtnBewaren_Click(object sender, RoutedEventArgs e)
        {
        }
        private void BtnVerwijder_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
