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

namespace WpfApp2
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
        {
        String m1;
        String n1;
        String r1;
        String t1;
        public MainWindow()
        {
            InitializeComponent();
            
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
             n1 = n.Text;
        }

        private void m_TextChanged(object sender, TextChangedEventArgs e)
        {
             m1 = m.Text;
        }

        private void r_TextChanged(object sender, TextChangedEventArgs e)
        {
             r1 = r.Text;
        }

        private void t_TextChanged(object sender, TextChangedEventArgs e)
        {
             t1 = t.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LayoutRoot.Children.Clear();
            Kachel nein = new Kachel(Convert.ToInt32(n1), Convert.ToInt32(m1), Convert.ToInt32(r1), Convert.ToInt32(t1));
            nein.kachelbauen(LayoutRoot);
        }
    }
    public class Kachel
    {

        Punkt Punkt_1 = new Punkt();
        Punkt Punkt_1 = new Punkt();
        Punkt Punkt_1 = new Punkt();
        Punkt Punkt_1 = new Punkt();
        Punkt Punkt_1 = new Punkt();
        Punkt Punkt_1 = new Punkt();
        private  double x1;
        private  double y1;
        private  double x2;
        private  double y2;
        private  double x3;
        private  double y3;
        private  double x4;
        private  double y4;
        private  double x5;
        private  double y5;
        private  double x6;
        private  double y6;
        private List<Punkt> koordinaten = new List<Punkt>();
        public Kachel(int n, int m, int r, int t)
        {
            for (int k = 0; k <= n; k++)
            {
                String prefix = k.ToString();
                String name = "Punkt" + prefix;
                Punkt Punkt + "" = new Punkt();
                
                double w = 2 * Math.PI * m / n;         // Mittelpunktswinkel

                x1 = r * Math.Cos((k + 1) * w + t);
                y1 = r * Math.Sin((k + 1) * w + t);

                punkt.set_x1(x1);
                punkt.set_y1(y1);

                koordinaten.Add(punkt);    // Koordinaten (x1,y1) des ersten Eckpunkts
                
                x2 = r * Math.Cos((k + 1) * w + t);     // Koordinaten (x2,y2) des zweiten Eckpunkts
                y2 = r * Math.Sin((k + 1) * w + t);
                x3 = r * Math.Cos((k + 2) * w + t);     // Koordinaten (x3,y3) des zweiten Eckpunkts
                y3 = r * Math.Sin((k + 2) * w + t);
                x4 = r * Math.Cos((k + 3) * w + t);     // Koordinaten (x4,y4) des zweiten Eckpunkts
                y4 = r * Math.Sin((k + 3) * w + t);
                x5 = r * Math.Cos((k + 4) * w + t);     // Koordinaten (x5,y5) des zweiten Eckpunkts
                y5 = r * Math.Sin((k + 4) * w + t);
                x6 = r * Math.Cos((k + 5) * w + t);     // Koordinaten (x6,y6) des zweiten Eckpunkts
                y6 = r * Math.Sin((k + 5) * w + t);
            }
        }

        public void berechneEcken()
        {
            
        }

        public void kachelbauen(Canvas LayoutRoot)
        {
            // Create a blue and a black Brush  
            SolidColorBrush yellowBrush = new SolidColorBrush();
            yellowBrush.Color = Colors.Yellow;
            SolidColorBrush blackBrush = new SolidColorBrush();
            blackBrush.Color = Colors.Black;
            // Create a Polygon  
            Polygon yellowPolygon = new Polygon();
            yellowPolygon.Stroke = blackBrush;
            yellowPolygon.Fill = yellowBrush;
            yellowPolygon.StrokeThickness = 4;
            // Create a collection of points for a polygon  
            System.Windows.Point Point1 = new System.Windows.Point(x1, y1);
            System.Windows.Point Point2 = new System.Windows.Point(x2, y2);
            System.Windows.Point Point3 = new System.Windows.Point(x3, y3);
            System.Windows.Point Point4 = new System.Windows.Point(x4, y4);
            System.Windows.Point Point5 = new System.Windows.Point(x5, y5);
            System.Windows.Point Point6 = new System.Windows.Point(x6, y6);
            PointCollection polygonPoints = new PointCollection();
            polygonPoints.Add(Point1);
            polygonPoints.Add(Point2);
            polygonPoints.Add(Point3);
            polygonPoints.Add(Point4);
            polygonPoints.Add(Point5);
            polygonPoints.Add(Point6);
            // Set Polygon.Points properties  
            yellowPolygon.Points = polygonPoints;
            // Add Polygon to the page  
            LayoutRoot.Children.Add(yellowPolygon);
        }
    }
    public class Punkt
    {
        private double x1;
        private double y1;

        public Punkt(double x1, double y1)
        {
            this.x1 = x1;
            this.y1 = y1;
        }
        public Punkt()
        {
        }
        public double get_x1()
        {
            return x1;
        }
        public double get_y1()
        {
            return y1;
        }

        public void set_x1(double x1)
        {
            this.x1 = x1;
        }
        public void set_y1(double y1)
        {
            this.y1 = y1;
        }

    }
}
