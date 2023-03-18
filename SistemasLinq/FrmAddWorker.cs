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
    public partial class FrmAddWorker : MaterialSkin.Controls.MaterialForm
    {
        DataClasses1DataContext dataContext;

        public FrmAddWorker()
        {
            
            InitializeComponent();
            cbmusu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbmpuesto.DropDownStyle = ComboBoxStyle.DropDownList;
            string Conexion = ConfigurationManager.ConnectionStrings["SistemasLinq.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void FrmAddWorker_Load(object sender, EventArgs e)
        {
            materialRaisedButton3_Click(sender, e);
            var query = from u in dataContext.usuarios select u.id;
            foreach (var idus in query)
            {
                cbmusu.Items.Add(idus);
            }
            var query2 = from p in dataContext.puesto select p.id_puesto;
            foreach(var ids in query2)
            {
                cbmpuesto.Items.Add(ids);
            }

        }

        private void materialLabel8_Click(object sender, EventArgs e)
        {
           

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            trabajador datos = new trabajador();
            datos.nombre = txtuser.Text;
            datos.apellido_pat = txtapepat.Text;
            datos.apellido_mat = txtapemat.Text;
            datos.direccion = txtdireccion.Text;
            datos.telefono = txttelefono.Text;
            datos.num_empleado = Convert.ToInt32(txtnumemp.Text);
            datos.id_usuario = Convert.ToInt32(cbmusu.SelectedItem); 
            datos.id_puesto = Convert.ToInt32(cbmpuesto.SelectedItem); 

            dataContext.trabajador.InsertOnSubmit(datos);
            dataContext.SubmitChanges();
            MessageBox.Show("Trabakador Guardado");
            txtuser.Text = "";
            txtapepat.Text = "";
            txtapemat.Text = "";
            txtdireccion.Text = "";
            txttelefono.Text = "";
            txtnumemp.Text = "";
            cbmusu.Text = "";
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
