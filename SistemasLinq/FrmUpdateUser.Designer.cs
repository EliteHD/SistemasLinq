namespace SistemasLinq
{
    partial class FrmUpdateUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtpass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtuser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbname = new System.Windows.Forms.ComboBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.cbmTipo = new System.Windows.Forms.ComboBox();
            this.cbmEstado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 33);
            this.label1.TabIndex = 24;
            this.label1.Text = "Modificar Usuario";
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.SystemColors.Window;
            this.txtpass.Depth = 0;
            this.txtpass.Hint = "";
            this.txtpass.Location = new System.Drawing.Point(215, 292);
            this.txtpass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '\0';
            this.txtpass.SelectedText = "";
            this.txtpass.SelectionLength = 0;
            this.txtpass.SelectionStart = 0;
            this.txtpass.Size = new System.Drawing.Size(219, 23);
            this.txtpass.TabIndex = 21;
            this.txtpass.UseSystemPasswordChar = false;
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.SystemColors.Window;
            this.txtuser.Depth = 0;
            this.txtuser.Hint = "";
            this.txtuser.Location = new System.Drawing.Point(215, 236);
            this.txtuser.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtuser.Name = "txtuser";
            this.txtuser.PasswordChar = '\0';
            this.txtuser.SelectedText = "";
            this.txtuser.SelectionLength = 0;
            this.txtuser.SelectionStart = 0;
            this.txtuser.Size = new System.Drawing.Size(219, 23);
            this.txtuser.TabIndex = 20;
            this.txtuser.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(308, 474);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(105, 39);
            this.materialRaisedButton3.TabIndex = 19;
            this.materialRaisedButton3.Text = "Cerrar";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(162, 474);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(105, 39);
            this.materialRaisedButton1.TabIndex = 17;
            this.materialRaisedButton1.Text = "Agregar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(147, 404);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(39, 19);
            this.materialLabel4.TabIndex = 16;
            this.materialLabel4.Text = "Tipo";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(130, 347);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(56, 19);
            this.materialLabel3.TabIndex = 15;
            this.materialLabel3.Text = "Estado";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(111, 292);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 19);
            this.materialLabel2.TabIndex = 14;
            this.materialLabel2.Text = "Password";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(123, 236);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(63, 19);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(457, 33);
            this.label2.TabIndex = 25;
            this.label2.Text = "__________________________";
            // 
            // cbname
            // 
            this.cbname.BackColor = System.Drawing.SystemColors.Window;
            this.cbname.FormattingEnabled = true;
            this.cbname.Location = new System.Drawing.Point(97, 182);
            this.cbname.Name = "cbname";
            this.cbname.Size = new System.Drawing.Size(294, 21);
            this.cbname.TabIndex = 26;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(417, 173);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(76, 36);
            this.materialFlatButton1.TabIndex = 27;
            this.materialFlatButton1.Text = "Mostrar";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // cbmTipo
            // 
            this.cbmTipo.FormattingEnabled = true;
            this.cbmTipo.Items.AddRange(new object[] {
            "Administrador",
            "Root",
            "Trabajador",
            "Normal",
            "Solo lectura",
            "Restringido"});
            this.cbmTipo.Location = new System.Drawing.Point(215, 402);
            this.cbmTipo.Name = "cbmTipo";
            this.cbmTipo.Size = new System.Drawing.Size(219, 21);
            this.cbmTipo.TabIndex = 23;
            // 
            // cbmEstado
            // 
            this.cbmEstado.BackColor = System.Drawing.SystemColors.Window;
            this.cbmEstado.FormattingEnabled = true;
            this.cbmEstado.Items.AddRange(new object[] {
            "Activo",
            "Suspendido",
            "Bloqueado"});
            this.cbmEstado.Location = new System.Drawing.Point(215, 348);
            this.cbmEstado.Name = "cbmEstado";
            this.cbmEstado.Size = new System.Drawing.Size(219, 21);
            this.cbmEstado.TabIndex = 22;
            // 
            // FrmUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 553);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.cbname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbmTipo);
            this.Controls.Add(this.cbmEstado);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.label2);
            this.Name = "FrmUpdateUser";
            this.Text = "FrmUpdateUser";
            this.Load += new System.EventHandler(this.FrmUpdateUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtpass;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtuser;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbname;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.ComboBox cbmTipo;
        private System.Windows.Forms.ComboBox cbmEstado;
    }
}