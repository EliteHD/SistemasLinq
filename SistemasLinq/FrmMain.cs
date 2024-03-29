﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasLinq
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            exitToolStripMenuItem_Click(sender, e);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddUser AddUser = new FrmAddUser();
            AddUser.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeleteUser deluser = new FrmDeleteUser();
            deluser.Show();
            this.Hide();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUpdateUser updateuser = new FrmUpdateUser(); 
            updateuser.Show();
            this.Hide();
        }

        private void listUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViewUser frmViewUser = new FrmViewUser();
            frmViewUser.Show();
            this.Hide();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAddWorker frmAddWorker = new FrmAddWorker();
            frmAddWorker.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDeleteWorker frmDeleteWorker = new FrmDeleteWorker();
            frmDeleteWorker.Show();
            this.Hide();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUpdateWorker frmUpdateWorker = new FrmUpdateWorker();
            frmUpdateWorker.Show();
            this.Hide();
        }

        private void listWorkersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViewWorler frmViewWorler = new FrmViewWorler();
            frmViewWorler.Show();
            this.Hide();
        }

        private void paysToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmAddSalary frmAddPay = new FrmAddSalary();
            frmAddPay.Show();
            this.Hide();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmDeleteSalary frmDeletePay = new FrmDeleteSalary();
            frmDeletePay.Show();
            this.Hide();
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmUpdateSalary frmUpdatePay = new FrmUpdateSalary();
            frmUpdatePay.Show();
            this.Hide();
        }

        private void listPaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViewSalary frmViewPay = new FrmViewSalary();
            frmViewPay.Show();
            this.Hide();
        }
    }
}
