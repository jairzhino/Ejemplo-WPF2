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
using ContraladorBusqueda;
namespace Ejemplo_WPF2
{
    /// <summary>
    /// Interaction logic for frmListaAlumnos.xaml
    /// </summary>
    public partial class frmaAlumnosList : UserControl, IResultadoUserControl
    {
        
        public frmaAlumnosList()
        {
            InitializeComponent();
            CargarLista();
        }

        public event MiEventoHandler ResultadoUserControl;

        public void CargarLista()
        {
            dgDatos.ItemsSource = null;
            dgDatos.ItemsSource = MainWindow.mananger.ListaAlumnos;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frmAlumnos f = new frmAlumnos();
            ContraladorB contraldorb=new ContraladorB(f);
            bool? bolok = contraldorb.ShowDialog();
            if (bolok != null && bolok.Value)
            {
                Alumnos alumno = (Alumnos)contraldorb.objeto;
                MessageBox.Show("Guardado correctamente Alumno : " +  alumno.Nombre);
            }
               
        }
    }
    public class Alumnos
    {
        public string Nombre { get; set; }
        public string Curso { get; set; }
        public Tutor OBJTutor { get; set; }
    }
    
}
