using System;
using System.Windows;
using FastInfoInput.Model;
using FastInfoInput.View;

namespace FastInfoInput
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Data _data = new Data();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(FromTextBox.Text + ", " + ToTextBox.Text);
            MemberInfoWindow memberInfoWindow = new MemberInfoWindow();
            memberInfoWindow.ShowDialog();
        }

        private void FromTextBox_Leave(object sender, System.EventArgs e)
        {
            Console.WriteLine("!!!!");
        }
    }
}
