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

        public static void ChangeUserControl(object Usercontrol)
        {

        }
    }
    public class Manager
    {
        public List<Alumnos> ListAlumnos{ get; set; }
        public List<Tutor> ListTutor { get; set; }
    }
}
