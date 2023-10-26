namespace Gabriel_Fernandez_Waisberg_2C
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cmbTipoVehiculo = new ComboBox();
            lblTipo = new Label();
            pcbFabrica = new PictureBox();
            btnFabricar = new Button();
            btnEliminar = new Button();
            lstVehiculos = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pcbFabrica).BeginInit();
            SuspendLayout();
            // 
            // cmbTipoVehiculo
            // 
            cmbTipoVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoVehiculo.FormattingEnabled = true;
            cmbTipoVehiculo.Location = new Point(651, 50);
            cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            cmbTipoVehiculo.Size = new Size(118, 23);
            cmbTipoVehiculo.TabIndex = 0;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(651, 32);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(55, 15);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Vehiculo:";
            // 
            // pcbFabrica
            // 
            pcbFabrica.Image = (Image)resources.GetObject("pcbFabrica.Image");
            pcbFabrica.Location = new Point(674, 95);
            pcbFabrica.Name = "pcbFabrica";
            pcbFabrica.Size = new Size(58, 72);
            pcbFabrica.TabIndex = 2;
            pcbFabrica.TabStop = false;
            // 
            // btnFabricar
            // 
            btnFabricar.Location = new Point(650, 211);
            btnFabricar.Name = "btnFabricar";
            btnFabricar.Size = new Size(127, 46);
            btnFabricar.TabIndex = 3;
            btnFabricar.Text = "Fabricar";
            btnFabricar.UseVisualStyleBackColor = true;
            btnFabricar.Click += btnFabricar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(650, 283);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(127, 46);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.HorizontalScrollbar = true;
            lstVehiculos.ItemHeight = 15;
            lstVehiculos.Location = new Point(12, 17);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.Size = new Size(610, 319);
            lstVehiculos.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 361);
            Controls.Add(lstVehiculos);
            Controls.Add(btnEliminar);
            Controls.Add(btnFabricar);
            Controls.Add(pcbFabrica);
            Controls.Add(lblTipo);
            Controls.Add(cmbTipoVehiculo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fabrica de Vehiculos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pcbFabrica).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipoVehiculo;
        private Label lblTipo;
        private PictureBox pcbFabrica;
        private Button btnFabricar;
        private Button btnEliminar;
        private ListBox lstVehiculos;
    }
}