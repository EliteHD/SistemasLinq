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
    public partial class FrmUpdateUser : MaterialSkin.Controls.MaterialForm
    {
        DataClasses1DataContext dataContext;
        public List<usuarios> listausuarios;

        public FrmUpdateUser()
        {
            InitializeComponent();
            string Conexion = ConfigurationManager.ConnectionStrings["SistemasLinq.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void FrmUpdateUser_Load(object sender, EventArgs e)
        {
            var lista = dataContext.usuarios.OrderBy(x => x.id).ToList();
            foreach (usuarios usuario in lista)
            {
                cbname.Items.Add(usuario.usuario);
            }

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            usuarios usuario = dataContext.usuarios.Where(x => x.usuario == cbname.Text).FirstOrDefault();
            usuario.usuario = txtuser.Text;
            usuario.passwd = txtpass.Text;
            usuario.estado = cbmEstado.Text;
            usuario.tipo_usuario = cbmTipo.Text;
            dataContext.SubmitChanges();
            MessageBox.Show("Usuario actualizado");
            cbname.Items.Clear();
            cbname.Text = "";
            FrmUpdateUser_Load(sender, e);
            txtuser.Text = "";
            txtpass.Text = "";
            cbmEstado.Text = "";
            cbmTipo.Text = "";


        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            usuarios usuario = dataContext.usuarios.Where(x => x.usuario == cbname.Text).FirstOrDefault();
            txtuser.Text = usuario.usuario;
            txtpass.Text = usuario.passwd;
            cbmEstado.Text = usuario.estado;
            cbmTipo.Text = usuario.tipo_usuario;

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void cbname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
