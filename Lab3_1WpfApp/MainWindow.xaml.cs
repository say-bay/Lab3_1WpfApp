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

namespace Lab3WpfApp
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

        private void ComboBox_SelectionChanged(object comboBox1, SelectionChangedEventArgs e)
        {
            string fontName = ((comboBox1 as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(fontName);
            }
        }

        private void ComboBox_SelectionChanged_1(object comboBox2, SelectionChangedEventArgs e)
        {
            string fontSize = ((comboBox2 as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
            {
                textBox.FontSize = System.Convert.ToDouble(fontSize);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                if (textBox.FontWeight != (FontWeight)System.ComponentModel.TypeDescriptor.GetConverter(typeof(FontWeight)).ConvertFromInvariantString("Bold"))
                {
                    textBox.FontWeight = (FontWeight)System.ComponentModel.TypeDescriptor.GetConverter(typeof(FontWeight)).ConvertFromInvariantString("Bold");
                }
                else
                {
                    textBox.FontWeight = (FontWeight)System.ComponentModel.TypeDescriptor.GetConverter(typeof(FontWeight)).ConvertFromInvariantString("1");
                }
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                if (textBox.FontStyle != (FontStyle)System.ComponentModel.TypeDescriptor.GetConverter(typeof(FontStyle)).ConvertFromInvariantString("Italic"))
                {
                    textBox.FontStyle = (FontStyle)System.ComponentModel.TypeDescriptor.GetConverter(typeof(FontStyle)).ConvertFromInvariantString("Italic");
                }
                else
                {
                    textBox.FontStyle = (FontStyle)System.ComponentModel.TypeDescriptor.GetConverter(typeof(FontStyle)).ConvertFromInvariantString("Normal");
                }
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (textBox.TextDecorations == null)
            {
                textBox.TextDecorations = TextDecorations.Underline;
            }
            else
            {
                textBox.TextDecorations = null;
            }
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Black;
            }
        }
        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Red;
            }
        }
    }
}
