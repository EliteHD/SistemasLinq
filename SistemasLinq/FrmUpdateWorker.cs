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
    public partial class FrmUpdateWorker : MaterialSkin.Controls.MaterialForm
    {
        DataClasses1DataContext dataContext;
        public List<trabajador> listatrabajador;
        public FrmUpdateWorker()
        {
            InitializeComponent();
            cbtraba.DropDownStyle = ComboBoxStyle.DropDownList;
            string Conexion = ConfigurationManager.ConnectionStrings["SistemasLinq.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void FrmUpdateWorker_Load(object sender, EventArgs e)
        {
            var lista = dataContext.trabajador.OrderBy(x => x.id_trabajador).ToList();
            foreach (trabajador trabajador in lista)
            {
                cbtraba.Items.Add(trabajador.nombre);
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            trabajador trabajador = dataContext.trabajador.FirstOrDefault(tr => tr.nombre.Equals(cbtraba.SelectedItem.ToString()));
            trabajador.nombre = txtuser.Text;
            trabajador.apellido_pat = txtapepat.Text;
            trabajador.apellido_mat = txtapemat.Text;
            trabajador.direccion = txtdireccion.Text;
            trabajador.telefono = txttelefono.Text;
            trabajador.num_empleado = Convert.ToInt32(txtnumemp.Text);
            trabajador.id_usuario = Convert.ToInt32(cbmusu.Text);
            trabajador.id_puesto = Convert.ToInt32(cbmpuesto.Text);
            dataContext.SubmitChanges();
            MessageBox.Show("Trabajador actualizado");
            cbtraba.Items.Clear();
            cbtraba.Text = "";
            FrmUpdateWorker_Load(sender, e);

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            trabajador trabajador = dataContext.trabajador.Where(x => x.nombre == cbtraba.Text).FirstOrDefault();
            txtuser.Text = trabajador.nombre;
            txtapepat.Text = trabajador.apellido_pat;
            txtapemat.Text = trabajador.apellido_mat;
            txtdireccion.Text = trabajador.direccion;
            txttelefono.Text = trabajador.telefono;
            txtnumemp.Text = trabajador.num_empleado.ToString();
            cbmusu.Text = trabajador.id_usuario.ToString();
            cbmpuesto.Text = trabajador.id_puesto.ToString();

        }
    }
}
