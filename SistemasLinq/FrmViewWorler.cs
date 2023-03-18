using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasLinq
{
    public partial class FrmViewWorler : MaterialSkin.Controls.MaterialForm
    {
        
        DataClasses1DataContext dataContext;
        public List<trabajador> listatrabajador;
        public FrmViewWorler()
        {
            InitializeComponent();
            string Conexion = ConfigurationManager.ConnectionStrings["SistemasLinq.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void FrmViewWorler_Load(object sender, EventArgs e)
        {
            listatrabajador = dataContext.trabajador.OrderBy(x => x.id_trabajador).ToList();
            dataGridView1.DataSource = listatrabajador;

        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();

        }
    }
}
