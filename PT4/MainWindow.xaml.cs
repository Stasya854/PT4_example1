﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PT4
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
        private void NewCommand_CanExecute(object sender,

         CanExecuteRoutedEventArgs e)

        {
            e.CanExecute = true;
        }
        private void NewCommand_Executed(object sender,

        ExecutedRoutedEventArgs e)
        {
            txtEditor.Text = "";
        }
    }
}