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
    public partial class FrmViewSalary : MaterialSkin.Controls.MaterialForm
    {
        DataClasses1DataContext dataContext;
        public List<sueldo> listasueldo;
        public FrmViewSalary()
        {
            InitializeComponent();
            string Conexion = ConfigurationManager.ConnectionStrings["SistemasLinq.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void FrmViewPay_Load(object sender, EventArgs e)
        {
            listasueldo = dataContext.sueldo.OrderBy(x => x.id_sueldo).ToList();
            dataGridView1.DataSource = listasueldo;


        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();
        }
    }
}
