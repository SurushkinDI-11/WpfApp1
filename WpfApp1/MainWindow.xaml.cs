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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool Caps = false;
        public MainWindow()
        {
            InitializeComponent();
        }




        private void Button_Start_Click(object sender, RoutedEventArgs e)
        {
            Button_Start.IsEnabled = false;
            Button_Stop.IsEnabled = true;
            output.Focusable = true;
            output.Focus();
        }

        private void Button_Stop_Click(object sender, RoutedEventArgs e)
        {
            Button_Start.IsEnabled = true;
            Button_Stop.IsEnabled = false;
            output.Focusable = false;
        }

        private void output_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.E)
            {

                BorderE.Background = new SolidColorBrush(Colors.White); output.Text += TextE.Text;

            }
            else if (e.Key == Key.R)

            {
                BorderR.Background = new SolidColorBrush(Colors.White);

                output.Text += TextR.Text;
            }

            else if (e.Key == Key.D)
            {

                BorderD.Background = new SolidColorBrush(Colors.White); output.Text += TextD.Text;

            }
            else if (e.Key == Key.F)

            {
                BorderF.Background = new SolidColorBrush(Colors.White);

                output.Text += TextF.Text;
            }
            if (e.Key == Key.CapsLock)

            {
                if (Caps == false)

                {
                    TextE.Text = TextE.Text.ToUpper();
                    TextR.Text = TextR.Text.ToUpper();
                    TextD.Text = TextD.Text.ToUpper();
                    TextF.Text = TextF.Text.ToUpper();
                    Caps = true;

                }
                else

                {
                    TextE.Text = TextE.Text.ToLower();
                    TextR.Text = TextR.Text.ToLower();
                    TextD.Text = TextD.Text.ToLower();
                    TextF.Text = TextF.Text.ToLower();
                    Caps = false;

                }
            }

            if (e.Key == Key.Back)

            {
                output.Text = output.Text.Substring(0, output.Text.Length - 1);

            }

            if (e.Key == Key.LeftShift)
            {

                if (Caps == false)
                {

                    TextE.Text = TextE.Text.ToUpper();
                    TextR.Text = TextR.Text.ToUpper();
                    TextD.Text = TextD.Text.ToUpper();
                    TextF.Text = TextF.Text.ToUpper();

                    Caps = true;
                }

                else
                {

                    TextE.Text = TextE.Text.ToLower();
                    TextR.Text = TextR.Text.ToLower();
                    TextD.Text = TextD.Text.ToLower();
                    TextF.Text = TextF.Text.ToLower();

                    Caps = false;
                }

            }
        }

        private void output_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.E)
            {

                BorderE.Background = new SolidColorBrush(Colors.LightYellow);

            }
            else if (e.Key == Key.R)

            {
                BorderR.Background = new SolidColorBrush(Colors.LightPink);

            }

            else if (e.Key == Key.D)
            {

                BorderD.Background = new SolidColorBrush(Colors.LightBlue);

            }
            else if (e.Key == Key.F)

            {
                BorderF.Background = new SolidColorBrush(Colors.LightGreen);

            }

            if (e.Key == Key.LeftShift)

            {
                if (Caps == false)

                {
                    TextE.Text = TextE.Text.ToUpper();
                    TextR.Text = TextR.Text.ToUpper();
                    TextD.Text = TextD.Text.ToUpper();
                    TextF.Text = TextF.Text.ToUpper();
                    Caps = true;

                }
                else
                {
                    TextE.Text = TextE.Text.ToLower();
                    TextR.Text = TextR.Text.ToLower();
                    TextD.Text = TextD.Text.ToLower();
                    TextF.Text = TextF.Text.ToLower();
                    Caps = false;
                }
            }
        }
    }
}
