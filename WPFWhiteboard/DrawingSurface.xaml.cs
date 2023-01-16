using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WPFWhiteboard
{
    /// <summary>
    /// Interaction logic for DrawingSurface.xaml
    /// </summary>
    public partial class DrawingSurface : UserControl
    {
        public DrawingSurface()
        {
            InitializeComponent();

            var rect = new Rectangle();
            rect.Stroke = new SolidColorBrush(Colors.Red);
            rect.Fill = new SolidColorBrush(Colors.Blue);
            rect.Width = ;
            rect.Height = 200;
            canvas.Children.Add(rect);
        }

        protected void OnMouseMove(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("Mouse moved" + e.MouseDevice.GetPosition(Mouse.Captured));
        }


        protected void OnMouseDown(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("Mouse down " + e.MouseDevice.GetPosition(Mouse.Captured));
        }

        protected void OnMouseEnter(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("Mouse enter " + Mouse.Captured);
        }

        protected void OnMouseLeave(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("Mouse leave " + Mouse.Captured);
        }
    }
}
