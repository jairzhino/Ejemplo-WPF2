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
    /// Interaction logic for frmTutor.xaml
    /// </summary>
    public partial class frmaTutorList : UserControl, IResultadoUserControl
    {
        public frmaTutorList()
        {
            InitializeComponent();
            CargarLista();
        }

        public event MiEventoHandler ResultadoUserControl;

        public void CargarLista()
        {
            dgDatos.ItemsSource = null;
            dgDatos.ItemsSource = MainWindow.mananger.ListaTutor;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frmTutor f = new frmTutor();
            ContraladorB controladorb = new ContraladorB(f);
            bool? bolok = controladorb.ShowDialog();
            if (bolok != null && bolok.Value)
            {
                Tutor tutor = (Tutor)controladorb.objeto;
                MessageBox.Show("Guardado correctamente Tutor : " + tutor.NombreTutor);
            }
        }
    }
    public class Tutor
    {
        public string NombreTutor { get; set; }
        public string Parentesco { get; set; }
    }
}
