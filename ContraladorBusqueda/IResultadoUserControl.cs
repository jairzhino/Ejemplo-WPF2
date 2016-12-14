using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContraladorBusqueda
{
    public delegate void MiEventoHandler(object obj);
    public interface IResultadoUserControl
    {
        event MiEventoHandler ResultadoUserControl;
    }
}
