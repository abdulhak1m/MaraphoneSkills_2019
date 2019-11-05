using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSR_0
{
    public partial class FormCheckPoint1 : Form
    {
        public FormCheckPoint1()
        {
            InitializeComponent();
            closeButton.Click += (s, e) => { Close(); };
        }
    }
}
