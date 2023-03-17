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

    public partial class FrmViewUser : MaterialSkin.Controls.MaterialForm
    {
        DataClasses1DataContext dataContext;
        public List<usuarios> listausuarios;


        public FrmViewUser()
        {
            InitializeComponent();
            string Conexion = ConfigurationManager.ConnectionStrings["SistemasLinq.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void FrmViewUser_Load(object sender, EventArgs e)
        {
            //Add the users from dataContext to the DataGridView
            listausuarios = dataContext.usuarios.OrderBy(x => x.id).ToList();
            dataGridView1.DataSource = listausuarios;


        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            FrmMain inicio = new FrmMain();
            inicio.Show();
            this.Hide();
        }
    }
}
