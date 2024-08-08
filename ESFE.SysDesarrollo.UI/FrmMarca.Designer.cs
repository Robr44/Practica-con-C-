namespace ESFE.SysDesarrollo.UI
{
    partial class FrmMarca
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
            this.txtNumID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.txtRegMar = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Descrip = new System.Windows.Forms.Label();
            this.lbl_RegM = new System.Windows.Forms.Label();
            this.btnInser = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnObtener = new System.Windows.Forms.Button();
            this.DataGV = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumID
            // 
            this.txtNumID.Location = new System.Drawing.Point(272, 30);
            this.txtNumID.Name = "txtNumID";
            this.txtNumID.Size = new System.Drawing.Size(140, 20);
            this.txtNumID.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(272, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(272, 118);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(140, 20);
            this.txtDescrip.TabIndex = 2;
            // 
            // txtRegMar
            // 
            this.txtRegMar.Location = new System.Drawing.Point(272, 162);
            this.txtRegMar.Name = "txtRegMar";
            this.txtRegMar.Size = new System.Drawing.Size(140, 20);
            this.txtRegMar.TabIndex = 3;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(107, 37);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(16, 13);
            this.lbl_ID.TabIndex = 4;
            this.lbl_ID.Text = "Id";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(107, 82);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 5;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Descrip
            // 
            this.lbl_Descrip.AutoSize = true;
            this.lbl_Descrip.Location = new System.Drawing.Point(107, 125);
            this.lbl_Descrip.Name = "lbl_Descrip";
            this.lbl_Descrip.Size = new System.Drawing.Size(63, 13);
            this.lbl_Descrip.TabIndex = 6;
            this.lbl_Descrip.Text = "Descripcion";
            // 
            // lbl_RegM
            // 
            this.lbl_RegM.AutoSize = true;
            this.lbl_RegM.Location = new System.Drawing.Point(107, 169);
            this.lbl_RegM.Name = "lbl_RegM";
            this.lbl_RegM.Size = new System.Drawing.Size(94, 13);
            this.lbl_RegM.TabIndex = 7;
            this.lbl_RegM.Text = "Registro de Marca";
            // 
            // btnInser
            // 
            this.btnInser.Location = new System.Drawing.Point(79, 212);
            this.btnInser.Name = "btnInser";
            this.btnInser.Size = new System.Drawing.Size(91, 31);
            this.btnInser.TabIndex = 8;
            this.btnInser.Text = "Insertar";
            this.btnInser.UseVisualStyleBackColor = true;
            this.btnInser.Click += new System.EventHandler(this.btnInser_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(325, 212);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(126, 31);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar Por nombre";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(482, 212);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(91, 31);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnObtener
            // 
            this.btnObtener.Location = new System.Drawing.Point(201, 212);
            this.btnObtener.Name = "btnObtener";
            this.btnObtener.Size = new System.Drawing.Size(91, 31);
            this.btnObtener.TabIndex = 11;
            this.btnObtener.Text = "Obtener Todos";
            this.btnObtener.UseVisualStyleBackColor = true;
            this.btnObtener.Click += new System.EventHandler(this.btnObtener_Click);
            // 
            // DataGV
            // 
            this.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV.Location = new System.Drawing.Point(110, 262);
            this.DataGV.Name = "DataGV";
            this.DataGV.Size = new System.Drawing.Size(510, 176);
            this.DataGV.TabIndex = 12;
            this.DataGV.SelectionChanged += new System.EventHandler(this.DataGV_SelectionChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(603, 212);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 31);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.DataGV);
            this.Controls.Add(this.btnObtener);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnInser);
            this.Controls.Add(this.lbl_RegM);
            this.Controls.Add(this.lbl_Descrip);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.txtRegMar);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNumID);
            this.Name = "FrmMarca";
            this.Text = "FrmMarca";
            this.Load += new System.EventHandler(this.FrmMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.TextBox txtRegMar;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Descrip;
        private System.Windows.Forms.Label lbl_RegM;
        private System.Windows.Forms.Button btnInser;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnObtener;
        private System.Windows.Forms.DataGridView DataGV;
        private System.Windows.Forms.Button btnEliminar;
    }
}