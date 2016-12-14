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

namespace Ejemplo_WPF2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Manager mananger { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        public static void MostrarContenedores(object Usercontrol,Grid grid)
        {
            grid.Children.Clear();
            ScrollViewer sv = new ScrollViewer();
            sv.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
            sv.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
            sv.Content = Usercontrol;
            grid.Children.Add(sv);            
        }

        private void btnListAlumnos_Click(object sender, RoutedEventArgs e)
        {
            frmListaAlumnos f = new frmListaAlumnos();
            MostrarContenedores(f,contenedor);
        }

        private void btnAlumnos_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnListTutores_Click(object sender, RoutedEventArgs e)
        {
            frmListaTutor f = new frmListaTutor();
            MostrarContenedores(f, contenedor);
        }

        private void btnTutor_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    public class Manager
    {
        public List<Alumnos> ListAlumnos{ get; set; }
        public List<Tutor> ListTutor { get; set; }
    }
}
