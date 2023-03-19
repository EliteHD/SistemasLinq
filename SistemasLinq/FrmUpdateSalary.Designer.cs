namespace SistemasLinq
{
    partial class FrmUpdateSalary
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtsueldo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.cbmpuesto = new System.Windows.Forms.ComboBox();
            this.cbmtraba = new System.Windows.Forms.ComboBox();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.cbmsalary = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 33);
            this.label1.TabIndex = 81;
            this.label1.Text = "Actualiza Sueldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(457, 33);
            this.label2.TabIndex = 82;
            this.label2.Text = "__________________________";
            // 
            // txtsueldo
            // 
            this.txtsueldo.BackColor = System.Drawing.SystemColors.Window;
            this.txtsueldo.Depth = 0;
            this.txtsueldo.Hint = "";
            this.txtsueldo.Location = new System.Drawing.Point(199, 298);
            this.txtsueldo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtsueldo.Name = "txtsueldo";
            this.txtsueldo.PasswordChar = '\0';
            this.txtsueldo.SelectedText = "";
            this.txtsueldo.SelectionLength = 0;
            this.txtsueldo.SelectionStart = 0;
            this.txtsueldo.Size = new System.Drawing.Size(219, 23);
            this.txtsueldo.TabIndex = 80;
            this.txtsueldo.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(116, 298);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(55, 19);
            this.materialLabel1.TabIndex = 79;
            this.materialLabel1.Text = "Sueldo";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(292, 230);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(76, 19);
            this.materialLabel8.TabIndex = 78;
            this.materialLabel8.Text = "Id. Puesto";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(153, 230);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(101, 19);
            this.materialLabel7.TabIndex = 77;
            this.materialLabel7.Text = "Id. Trabajador";
            // 
            // cbmpuesto
            // 
            this.cbmpuesto.FormattingEnabled = true;
            this.cbmpuesto.Location = new System.Drawing.Point(287, 252);
            this.cbmpuesto.Name = "cbmpuesto";
            this.cbmpuesto.Size = new System.Drawing.Size(82, 21);
            this.cbmpuesto.TabIndex = 76;
            // 
            // cbmtraba
            // 
            this.cbmtraba.FormattingEnabled = true;
            this.cbmtraba.Location = new System.Drawing.Point(163, 252);
            this.cbmtraba.Name = "cbmtraba";
            this.cbmtraba.Size = new System.Drawing.Size(82, 21);
            this.cbmtraba.TabIndex = 75;
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(287, 360);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(105, 39);
            this.materialRaisedButton3.TabIndex = 84;
            this.materialRaisedButton3.Text = "Cerrar";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(141, 360);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(105, 39);
            this.materialRaisedButton1.TabIndex = 83;
            this.materialRaisedButton1.Text = "Actualizar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(394, 165);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(76, 36);
            this.materialFlatButton1.TabIndex = 86;
            this.materialFlatButton1.Text = "Mostrar";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // cbmsalary
            // 
            this.cbmsalary.BackColor = System.Drawing.SystemColors.Window;
            this.cbmsalary.FormattingEnabled = true;
            this.cbmsalary.Location = new System.Drawing.Point(74, 174);
            this.cbmsalary.Name = "cbmsalary";
            this.cbmsalary.Size = new System.Drawing.Size(294, 21);
            this.cbmsalary.TabIndex = 85;
            // 
            // FrmUpdatePay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 484);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.cbmsalary);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsueldo);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.cbmpuesto);
            this.Controls.Add(this.cbmtraba);
            this.Name = "FrmUpdatePay";
            this.Text = "FrmUpdatePay";
            this.Load += new System.EventHandler(this.FrmUpdatePay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtsueldo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.ComboBox cbmpuesto;
        private System.Windows.Forms.ComboBox cbmtraba;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.ComboBox cbmsalary;
    }
}