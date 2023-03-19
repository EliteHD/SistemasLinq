namespace SistemasLinq
{
    partial class FrmAddSalary
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
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.cbmpuesto = new System.Windows.Forms.ComboBox();
            this.cbmtraba = new System.Windows.Forms.ComboBox();
            this.txtsueldo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(279, 179);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(76, 19);
            this.materialLabel8.TabIndex = 64;
            this.materialLabel8.Text = "Id. Puesto";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(140, 179);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(101, 19);
            this.materialLabel7.TabIndex = 63;
            this.materialLabel7.Text = "Id. Trabajador";
            // 
            // cbmpuesto
            // 
            this.cbmpuesto.FormattingEnabled = true;
            this.cbmpuesto.Location = new System.Drawing.Point(274, 201);
            this.cbmpuesto.Name = "cbmpuesto";
            this.cbmpuesto.Size = new System.Drawing.Size(82, 21);
            this.cbmpuesto.TabIndex = 61;
            // 
            // cbmtraba
            // 
            this.cbmtraba.FormattingEnabled = true;
            this.cbmtraba.Location = new System.Drawing.Point(150, 201);
            this.cbmtraba.Name = "cbmtraba";
            this.cbmtraba.Size = new System.Drawing.Size(82, 21);
            this.cbmtraba.TabIndex = 60;
            // 
            // txtsueldo
            // 
            this.txtsueldo.BackColor = System.Drawing.SystemColors.Window;
            this.txtsueldo.Depth = 0;
            this.txtsueldo.Hint = "";
            this.txtsueldo.Location = new System.Drawing.Point(186, 247);
            this.txtsueldo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtsueldo.Name = "txtsueldo";
            this.txtsueldo.PasswordChar = '\0';
            this.txtsueldo.SelectedText = "";
            this.txtsueldo.SelectionLength = 0;
            this.txtsueldo.SelectionStart = 0;
            this.txtsueldo.Size = new System.Drawing.Size(219, 23);
            this.txtsueldo.TabIndex = 68;
            this.txtsueldo.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(103, 247);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(55, 19);
            this.materialLabel1.TabIndex = 66;
            this.materialLabel1.Text = "Sueldo";
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(274, 321);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(105, 39);
            this.materialRaisedButton3.TabIndex = 72;
            this.materialRaisedButton3.Text = "Cerrar";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(107, 321);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(105, 39);
            this.materialRaisedButton1.TabIndex = 70;
            this.materialRaisedButton1.Text = "Agregar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 33);
            this.label1.TabIndex = 73;
            this.label1.Text = "Agregar Sueldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(457, 33);
            this.label2.TabIndex = 74;
            this.label2.Text = "__________________________";
            // 
            // FrmAddPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.txtsueldo);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.cbmpuesto);
            this.Controls.Add(this.cbmtraba);
            this.Name = "FrmAddPay";
            this.Text = "FrmAddPay";
            this.Load += new System.EventHandler(this.FrmAddPay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.ComboBox cbmpuesto;
        private System.Windows.Forms.ComboBox cbmtraba;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtsueldo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}