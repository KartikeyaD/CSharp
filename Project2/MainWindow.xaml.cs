using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Project2
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void ConvertToBase13_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(InputTextBox.Text, out int number))
            {
                string base13 = BaseConverter.ToBase13(number);
                OutputTextBlock.Text = $"Base 13: {base13}";
            }
            else
            {
                OutputTextBlock.Text = "Invalid input!";
            }
        }
        private void ConvertFromBase13_Click(object sender, RoutedEventArgs e)
        {
            int b10 = BaseConverter.FromBase13(InputTextBox.Text);
            string base10 = b10.ToString();
            OutputTextBlock.Text = $"Base 10: {base10}";
        }
    }
}
