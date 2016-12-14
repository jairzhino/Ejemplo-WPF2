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
    public partial class frmTutor : UserControl, IResultadoUserControl
    {
        private Tutor tutor;
        public frmTutor()
        {
            InitializeComponent();
            tutor = new Tutor();
            gridobjecto.DataContext = tutor;
        }

        public event MiEventoHandler ResultadoUserControl;

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tutor.NombreTutor) && !string.IsNullOrEmpty(tutor.Parentesco))
            {
                MainWindow.mananger.ListaTutor.Add(tutor);
                //MessageBox.Show("Guardado correctamente");
                //tutor = new Tutor();
                ResultadoUserControl?.Invoke(tutor);
            }
            else
                MessageBox.Show("Debes llenar los campos");
        }
    }
}
