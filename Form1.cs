using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicaciòn_Cronometro
{
    public partial class frmCronometro : Form
    {
        private Timer Tiempo;
        private int minutos;
        private int segundo;

        public frmCronometro()
        {
            InitializeComponent();
        }

        private void frmCronometro_Load(object sender, EventArgs e)
        {

        }
    }
}
