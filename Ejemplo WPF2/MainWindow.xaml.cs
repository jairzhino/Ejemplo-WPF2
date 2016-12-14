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
            mananger = new Manager();
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
            frmaAlumnosList f = new frmaAlumnosList();
            MostrarContenedores(f,contenedor);
        }

   
        private void btnListTutores_Click(object sender, RoutedEventArgs e)
        {
            frmaTutorList f = new frmaTutorList();
            MostrarContenedores(f, contenedor);
        }

        private void btnAlumnos_Click(object sender, RoutedEventArgs e)
        {
            frmAlumnos f = new frmAlumnos();
            MostrarContenedores(f, contenedor);
        }

        private void btnTutores_Click(object sender, RoutedEventArgs e)
        {
            frmTutor f = new frmTutor();
            MostrarContenedores(f, contenedor);
        }
    }
    public class Manager
    {
        public List<Alumnos> ListaAlumnos{ get; set; }
        public List<Tutor> ListaTutor { get; set; }

        public Manager()
        {
            ListaAlumnos = new List<Alumnos>();
            ListaTutor = new List<Tutor>();
            ListaTutor.Add(new Tutor() { NombreTutor = "Juan Percy", Parentesco = "Padre" });
            ListaTutor.Add(new Tutor() { NombreTutor = "Juana Guilen", Parentesco = "Madre" });
            ListaTutor.Add(new Tutor() { NombreTutor = "Pedro Magallanes", Parentesco = "Tio" });
            ListaAlumnos.Add(new Alumnos() { Nombre = "Pepito Percy", Curso = "4to Primaria" });
            ListaAlumnos.Add(new Alumnos() { Nombre = "Andresito Garcia", Curso = "5to Secundaria" });
            ListaAlumnos.Add(new Alumnos() { Nombre = "Analy Magallanes", Curso = "6to Primaria" });
        }
    }
}
