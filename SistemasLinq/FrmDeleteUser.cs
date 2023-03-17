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
    public partial class FrmDeleteUser : MaterialSkin.Controls.MaterialForm
    {
        DataClasses1DataContext dataContext;
            public List<usuarios> listausuarios;

        public FrmDeleteUser()
        {
            InitializeComponent();
            string Conexion = ConfigurationManager.ConnectionStrings["SistemasLinq.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void FrmDeleteUser_Load(object sender, EventArgs e)
        {
            var lista = dataContext.usuarios.OrderBy(x => x.id).ToList();
            foreach(usuarios usuario in lista)
            {
                cbmuser.Items.Add(usuario.usuario);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            //Delete the selected user from the cmbUsuarios
            usuarios user = dataContext.usuarios.FirstOrDefault(us => us.usuario.Equals(cbmuser.SelectedItem.ToString()));
            dataContext.usuarios.DeleteOnSubmit(user);
            dataContext.SubmitChanges();
            MessageBox.Show("Usuario eliminado");
            cbmuser.Items.Clear();
            cbmuser.Text = "";
            FrmDeleteUser_Load(sender, e);
        }
    }
}
