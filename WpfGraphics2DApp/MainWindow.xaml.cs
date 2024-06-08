using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfGraphics2DApp
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

        void PrimitiveExample()
        {
            //Ellipse el = new();
            //el.Width = 200;
            //el.Height = 120;
            //el.Fill = new LinearGradientBrush(new GradientStopCollection()
            //{
            //    new GradientStop(Colors.Magenta, 0),
            //    new GradientStop(Colors.Pink, 1),
            //});
            //stack.Children.Add(el);

            double width = this.Width;
            double height = this.Height;

            Line abscess = new();
            Line ordinate = new();

            abscess.X1 = width / 2;
            abscess.Y1 = 5f;
            abscess.X2 = width / 2;
            abscess.Y2 = height - 5;

            ordinate.X1 = 5f;
            ordinate.Y1 = height / 2;
            ordinate.X2 = width - 5;
            ordinate.Y2 = height / 2;

            abscess.Stroke = new SolidColorBrush(Colors.Blue);
            ordinate.Stroke = new SolidColorBrush(Colors.Blue);
            abscess.StrokeThickness = 5f;
            ordinate.StrokeThickness = 5f;

            grid.Children.Add(abscess);
            grid.Children.Add(ordinate);
        }
    }
}