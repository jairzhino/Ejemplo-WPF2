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
    /// Interaction logic for frmAlumnos.xaml
    /// </summary>
    public partial class frmAlumnos : UserControl
    {
        private Alumnos alumno;
        public frmAlumnos()
        {
            InitializeComponent();
            alumno = new Alumnos();
            cargarCombobox();
            gridobjecto.DataContext = alumno;
        }
        public void cargarCombobox()
        {
            cbtutor.ItemsSource = null;
            cbtutor.ItemsSource = MainWindow.mananger.ListaTutor;
            cbtutor.DisplayMemberPath = "NombreTutor";
        }
        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(alumno.Nombre) && !string.IsNullOrEmpty(alumno.Curso))
            {
                MainWindow.mananger.ListaAlumnos.Add(alumno);
                MessageBox.Show("Guardado correctamente");
                alumno = new Alumnos();
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
        }
    }
}
