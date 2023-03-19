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
using System.Xml.Linq;

namespace SistemasLinq
{
    public partial class FrmUpdateSalary : MaterialSkin.Controls.MaterialForm
    {
        DataClasses1DataContext dataContext;
        public List<sueldo> listasueldo;
        public FrmUpdateSalary()
        {
            InitializeComponent();
            string Conexion = ConfigurationManager.ConnectionStrings["SistemasLinq.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void FrmUpdatePay_Load(object sender, EventArgs e)
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
            var lista = dataContext.sueldo.OrderBy(x => x.id_sueldo).ToList();
            foreach (sueldo sueldo in lista)
            {
                cbmsalary.Items.Add(sueldo.id_sueldo);
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            sueldo sueldo = dataContext.sueldo.FirstOrDefault(su => su.id_sueldo.Equals(cbmsalary.SelectedItem.ToString()));
            cbmtraba.Text = sueldo.id_trabajador.ToString();
            cbmpuesto.Text = sueldo.id_puesto.ToString();
            txtsueldo.Text = sueldo.sueldo1.ToString();

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            sueldo sueldo = dataContext.sueldo.Where(x => x.id_sueldo == Convert.ToInt32(cbmsalary.Text)).FirstOrDefault();
            sueldo.id_trabajador = Convert.ToInt32(cbmtraba.SelectedItem);
            sueldo.id_puesto = Convert.ToInt32(cbmpuesto.SelectedItem);
            sueldo.sueldo1 = Convert.ToDouble(txtsueldo.Text);
            dataContext.SubmitChanges();
            MessageBox.Show("Sueldo actualizado");
            cbmsalary.Items.Clear();
            cbmsalary.Text = "";
            FrmUpdatePay_Load(sender, e);
            txtsueldo.Text = "";
            cbmtraba.Text  ="";
            cbmpuesto.Text  ="";

        }
    }
}
