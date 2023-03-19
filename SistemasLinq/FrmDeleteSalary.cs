using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasLinq
{
    public partial class FrmDeleteSalary : MaterialSkin.Controls.MaterialForm
    {
        DataClasses1DataContext dataContext;
        public List<sueldo> listasueldo;
        public FrmDeleteSalary()
        {
            InitializeComponent();
            string Conexion = ConfigurationManager.ConnectionStrings["SistemasLinq.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void FrmDeletePay_Load(object sender, EventArgs e)
        {
            var lista = dataContext.sueldo.OrderBy(x => x.id_sueldo).ToList();
            foreach (sueldo sueldo in lista)
            {
                cbmsalary.Items.Add(sueldo.id_sueldo);
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            sueldo sueldo = dataContext.sueldo.FirstOrDefault(su => su.id_sueldo.Equals(cbmsalary.SelectedItem.ToString()));
            dataContext.sueldo.DeleteOnSubmit(sueldo);
            dataContext.SubmitChanges();
            MessageBox.Show("Sueldo eliminado");
            cbmsalary.Items.Clear();
            cbmsalary.Text = "";
            FrmDeletePay_Load(sender, e);
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();
        }
    }
}
