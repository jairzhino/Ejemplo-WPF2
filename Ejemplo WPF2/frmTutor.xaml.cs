﻿using System;
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
    /// Interaction logic for frmTutor.xaml
    /// </summary>
    public partial class frmTutor : UserControl
    {
        public frmTutor()
        {
            InitializeComponent();
        }
    }
    public class Tutor
    {
        public string NombreTutor { get; set; }
        public string Parentesco { get; set; }
    }
}
