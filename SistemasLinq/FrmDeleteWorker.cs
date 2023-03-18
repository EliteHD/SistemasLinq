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
    public partial class FrmDeleteWorker : MaterialSkin.Controls.MaterialForm
    {
        DataClasses1DataContext dataContext;
        public List<trabajador> listatrabajador;
        public FrmDeleteWorker()
        {
            InitializeComponent();
            cbmuser.DropDownStyle = ComboBoxStyle.DropDownList;
            string Conexion = ConfigurationManager.ConnectionStrings["SistemasLinq.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void FrmDeleteWorker_Load(object sender, EventArgs e)
        {
            var lista = dataContext.trabajador.OrderBy(x => x.id_trabajador).ToList();
            foreach (trabajador trabajador in lista)
            {
                cbmuser.Items.Add(trabajador.nombre);
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            trabajador trabajador = dataContext.trabajador.FirstOrDefault(tr => tr.nombre.Equals(cbmuser.SelectedItem.ToString()));
            dataContext.trabajador.DeleteOnSubmit(trabajador);
            dataContext.SubmitChanges();
            MessageBox.Show("Trabajador eliminado");
            cbmuser.Items.Clear();
            cbmuser.Text = "";
            FrmDeleteWorker_Load(sender, e);
        }
    }
}
