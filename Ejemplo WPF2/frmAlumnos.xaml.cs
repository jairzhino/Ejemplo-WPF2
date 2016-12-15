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
    /// Interaction logic for frmAlumnos.xaml
    /// </summary>
    public partial class frmAlumnos : UserControl,IResultadoUserControl
    {
        private Alumnos alumno;
        public event MiEventoHandler ResultadoUserControl;
        public frmAlumnos()
        {
            InitializeComponent();
            alumno = new Alumnos();
            cargarCombobox();
            gridobjecto.DataContext = alumno;
        }

       

        public void cargarCombobox()
        {
            List<Tutor> l= new List<Tutor>(MainWindow.mananger.ListaTutor);
            l.Add(new Tutor() { NombreTutor="Nuevo Tutor", Parentesco="Ninguno"});
            cbtutor.ItemsSource = null;
            cbtutor.ItemsSource = l;
            cbtutor.DisplayMemberPath = "NombreTutor";
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(alumno.Nombre) && !string.IsNullOrEmpty(alumno.Curso))
            {
                MainWindow.mananger.ListaAlumnos.Add(alumno);
                //MessageBox.Show("Guardado correctamente");
                //alumno = new Alumnos();
                ResultadoUserControl?.Invoke(alumno);
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
        }

        private void selection_changedTutor(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Tutor t = (Tutor)cbtutor.SelectedItem;
                if (t.NombreTutor.Equals("Nuevo Tutor"))
                {
                    frmTutor f = new frmTutor();
                    ContraladorB cb = new ContraladorB(f);
                    bool? bolok = cb.ShowDialog();
                    if (bolok != null && bolok.Value)
                    {
                        cargarCombobox();
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
           
        }
    }
}
