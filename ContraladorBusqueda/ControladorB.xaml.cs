using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace ContraladorBusqueda
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ContraladorB : Window
    {
        public object objeto { get; set; }
        public ContraladorB()
        {
            InitializeComponent();
        }
        public ContraladorB(object uc)
        {
            InitializeComponent();

            EventInfo evt = uc.GetType().GetEvent("ResultadoUserControl");
            MethodInfo handler = this.GetType().GetMethod("ResultadoUserControlEvent");
            Delegate del = Delegate.CreateDelegate(evt.EventHandlerType,this,handler);
            evt.AddEventHandler(uc,del);

            UserControl c = (UserControl)uc;
            Height = c.Height + 50;
            Width = c.Width + 25;
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            ResizeMode = ResizeMode.NoResize;
            MostrarContenedores(uc,Contenedor);
        }
        public static void MostrarContenedores(object Usercontrol, Grid grid)
        {
            grid.Children.Clear();
            ScrollViewer sv = new ScrollViewer();
            sv.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
            sv.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
            sv.Content = Usercontrol;
            grid.Children.Add(sv);
        }
        public void ResultadoUserControlEvent(object obj)
        {
            objeto = obj;
            DialogResult = true;
        }
    }
}
