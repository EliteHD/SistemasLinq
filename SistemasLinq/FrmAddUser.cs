using Microsoft.IdentityModel.Protocols;
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
    public partial class FrmAddUser : MaterialSkin.Controls.MaterialForm
    {
        DataClasses1DataContext dataContext;
        public FrmAddUser()
        {
            InitializeComponent();
            cbmEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbmTipo.DropDownStyle = ComboBoxStyle.DropDownList;

            string Conexion = ConfigurationManager.ConnectionStrings["SistemasLinq.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAddUser_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            txtuser.Text = "";
            txtpass.Text = "";
            cbmEstado.Text = "";
            cbmTipo.Text = "";
        }

        private void FrmAddUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            materialRaisedButton3_Click(sender, e);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            usuarios datos = new usuarios();
            datos.usuario = txtuser.Text;
            datos.passwd = txtpass.Text;
            datos.estado = cbmEstado.Text;
            datos.tipo_usuario = cbmTipo.SelectedItem.ToString();
            dataContext.usuarios.InsertOnSubmit(datos);
            dataContext.SubmitChanges();
            MessageBox.Show("Usuario Guardado");
        }

    }
}
