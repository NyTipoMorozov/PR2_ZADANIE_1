using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PR2_ZADANIE_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtEditor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int row = txtEditor.GetLineIndexFromCharacterIndex(txtEditor.CaretIndex);
            int col = txtEditor.CaretIndex - txtEditor.GetCharacterIndexFromLineIndex(row);
            lblCursorPosition.Text = "Строка " + (row + 1) + ", Символов " + (col + 1);
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Button1.Background = Brushes.Green;
        }

        private void Button1_Click_1(object sender, RoutedEventArgs e)
        {
            Button2.Background = Brushes.Yellow;
        }

        private void Button1_Click_2(object sender, RoutedEventArgs e)
        {
            Button3.Background = Brushes.Red;
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Button4.Background = Brushes.Blue;
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            Button1.Background = Brushes.White;
            Button2.Background = Brushes.White;
            Button3.Background = Brushes.White;
            Button4.Background = Brushes.White;

        }

        private void txtEditor_SelectionChanged_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_MouseEnter(object sender, MouseEventArgs e)
        {
            StatusBar.Visibility = Visibility.Visible;
            TextBlock.Text = "Морозов Иван";
        }

        private void MenuItem_MouseLeave(object sender, MouseEventArgs e)
        {
            StatusBar.Visibility = Visibility.Collapsed;
        }

        private void txtEditor_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            Window1 Window1 = new Window1();
            Window1.Show();
        }
    }
}
