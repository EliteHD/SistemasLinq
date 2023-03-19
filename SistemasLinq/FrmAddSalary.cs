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
    public partial class FrmAddSalary : MaterialSkin.Controls.MaterialForm
    {
        DataClasses1DataContext dataContext;

        public FrmAddSalary()
        {
            InitializeComponent();
            cbmpuesto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbmtraba.DropDownStyle = ComboBoxStyle.DropDownList;
            string Conexion = ConfigurationManager.ConnectionStrings["SistemasLinq.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void FrmAddPay_Load(object sender, EventArgs e)
        {
            var query = from t in dataContext.trabajador select t.id_trabajador;
            foreach (var idtrab in query)
            {
                cbmtraba.Items.Add(idtrab);
            }
            var query2 = from p in dataContext.puesto select p.id_puesto;
            foreach (var idpuesto in query2)
            {
                cbmpuesto.Items.Add(idpuesto);
            }

        }

        private void txtnumemp_Click(object sender, EventArgs e)
        {
            
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            sueldo sueldos = new sueldo();
            sueldos.id_trabajador = Convert.ToInt32(cbmtraba.SelectedItem);
            sueldos.id_puesto = Convert.ToInt32(cbmpuesto.SelectedItem);
            sueldos.sueldo1 = Convert.ToDouble(txtsueldo.Text);
            dataContext.sueldo.InsertOnSubmit(sueldos);
            dataContext.SubmitChanges();
            MessageBox.Show("Se ha agregado el sueldo");
            txtsueldo.Text = "";
            cbmtraba.Text = "";
            cbmpuesto.Text = "";           
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();
        }
    }
}
