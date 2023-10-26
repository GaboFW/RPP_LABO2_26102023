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
            comboBox1 = new ComboBox();
            txtVehiculo = new Label();
            pictureBox1 = new PictureBox();
            btnFabricar = new Button();
            btnEliminar = new Button();
            lstVehiculos = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(651, 50);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(118, 23);
            comboBox1.TabIndex = 0;
            // 
            // txtVehiculo
            // 
            txtVehiculo.AutoSize = true;
            txtVehiculo.Location = new Point(651, 32);
            txtVehiculo.Name = "txtVehiculo";
            txtVehiculo.Size = new Size(55, 15);
            txtVehiculo.TabIndex = 1;
            txtVehiculo.Text = "Vehiculo:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(674, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 72);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnFabricar
            // 
            btnFabricar.Location = new Point(650, 211);
            btnFabricar.Name = "btnFabricar";
            btnFabricar.Size = new Size(127, 46);
            btnFabricar.TabIndex = 3;
            btnFabricar.Text = "Fabricar";
            btnFabricar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(650, 283);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(127, 46);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
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
            Controls.Add(pictureBox1);
            Controls.Add(txtVehiculo);
            Controls.Add(comboBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label txtVehiculo;
        private PictureBox pictureBox1;
        private Button btnFabricar;
        private Button btnEliminar;
        private ListBox lstVehiculos;
    }
}