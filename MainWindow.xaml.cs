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
using System.Windows.Threading;

namespace Sublimal
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(200);
            timer.Tick += timer_Tick;
            timer.Start();


            DispatcherTimer attributestimer = new DispatcherTimer();
            attributestimer.Interval = TimeSpan.FromMilliseconds(11);
            attributestimer.Tick += attrivutetimer;
            attributestimer.Start();
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            DrawObjects();
        }

        void DrawObjects()
        {

            Random rnd = new Random();
            DrawingCanvas.Children.Clear();
            for (int i = 0; i < 1; i++)
            {
                double x, y;

                x = rnd.NextDouble() * Width*2;
                y = rnd.NextDouble() * Height;

                Ellipse eli = new Ellipse();
                eli.Width = 20;
                eli.Height = 20;
                eli.Fill = new SolidColorBrush(Colors.Orange);

                Canvas.SetLeft(eli, x);
                Canvas.SetTop(eli, y);
                DrawingCanvas.Children.Add(eli);
            }

        }

        private void attrivutetimer(object sender, EventArgs e)
        {
            Random rnd = new Random();
           // int position = rnd.Next(0, 200);
           //var child= DrawingCanvas.Children[position] as Ellipse;

           // child.Fill = new SolidColorBrush(Colors.Yellow);
            
          //Random rnd = new Random();
            DrawingCanvas.Children.Clear();
            for (int i = 0; i < 1; i++)
            {
                double x, y;

                x = rnd.NextDouble() * Width;
                y = rnd.NextDouble() * Height;

                Ellipse eli = new Ellipse();
                eli.Width = 130;
                eli.Height =130;
                eli.Fill = new SolidColorBrush(Colors.Yellow);

                Canvas.SetLeft(eli, x);
                Canvas.SetTop(eli, y);
                DrawingCanvas.Children.Add(eli);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DrawObjects();
        }
    }
}
