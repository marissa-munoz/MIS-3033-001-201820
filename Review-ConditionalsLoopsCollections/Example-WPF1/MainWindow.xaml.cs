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

namespace Example_WPF1
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

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
        }

        private void canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Ellipse ell = new Ellipse()
            {
                Stroke = Brushes.Aquamarine,
                StrokeThickness = 5,
                Fill = Brushes.Gray,
                Height = 30,
                Width = 30,
            };

            //ell.Stroke = Brushes.Gold;

            canvas.Children.Add(ell);

        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            var mouseLocation = e.MouseDevice.GetPosition(canvas);
            Ellipse ell = new Ellipse();

            if (txtColor.Text == "red")
            {
                ell = new Ellipse()
                {
                    Stroke = Brushes.Red,
                    StrokeThickness = 5,
                    Fill = Brushes.Gray,
                    Height = 30,
                    Width = 30,
                };
            }

            ell = new Ellipse()
            {
                Stroke = Brushes.Aquamarine,
                StrokeThickness = 5,
                Fill = Brushes.Gray,
                Height = 30,
                Width = 30,
            };
            canvas.Children.Add(ell);

            Canvas.SetTop(ell, mouseLocation.Y -15);

            Canvas.SetLeft(ell, mouseLocation.X -15);
        }
    }
}
