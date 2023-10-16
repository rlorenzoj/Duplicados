namespace Duplicados
{
    partial class FrmPrincipal
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
            gbOrigen = new GroupBox();
            btnSeleccionarOrigen = new Button();
            lblOrigen = new Label();
            gbDestino = new GroupBox();
            btnDestino = new Button();
            lblDestino = new Label();
            gbDuplicados = new GroupBox();
            BtnBuscar = new Button();
            lstDuplicados = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            gbOrigen.SuspendLayout();
            gbDestino.SuspendLayout();
            gbDuplicados.SuspendLayout();
            SuspendLayout();
            // 
            // gbOrigen
            // 
            gbOrigen.Controls.Add(btnSeleccionarOrigen);
            gbOrigen.Controls.Add(lblOrigen);
            gbOrigen.Location = new Point(10, 9);
            gbOrigen.Margin = new Padding(3, 2, 3, 2);
            gbOrigen.Name = "gbOrigen";
            gbOrigen.Padding = new Padding(3, 2, 3, 2);
            gbOrigen.Size = new Size(1328, 41);
            gbOrigen.TabIndex = 0;
            gbOrigen.TabStop = false;
            gbOrigen.Text = "Origen de los archivos";
            // 
            // btnSeleccionarOrigen
            // 
            btnSeleccionarOrigen.Location = new Point(1168, 13);
            btnSeleccionarOrigen.Margin = new Padding(3, 2, 3, 2);
            btnSeleccionarOrigen.Name = "btnSeleccionarOrigen";
            btnSeleccionarOrigen.Size = new Size(154, 22);
            btnSeleccionarOrigen.TabIndex = 1;
            btnSeleccionarOrigen.Text = "Seleccionar";
            btnSeleccionarOrigen.UseVisualStyleBackColor = true;
            btnSeleccionarOrigen.Click += BtnSeleccionarOrigen_Click;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrigen.ForeColor = SystemColors.HotTrack;
            lblOrigen.Location = new Point(5, 17);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(40, 15);
            lblOrigen.TabIndex = 0;
            lblOrigen.Text = "label1";
            // 
            // gbDestino
            // 
            gbDestino.Controls.Add(btnDestino);
            gbDestino.Controls.Add(lblDestino);
            gbDestino.Location = new Point(10, 55);
            gbDestino.Margin = new Padding(3, 2, 3, 2);
            gbDestino.Name = "gbDestino";
            gbDestino.Padding = new Padding(3, 2, 3, 2);
            gbDestino.Size = new Size(1328, 41);
            gbDestino.TabIndex = 2;
            gbDestino.TabStop = false;
            gbDestino.Text = "Destino de los archivos";
            // 
            // btnDestino
            // 
            btnDestino.Location = new Point(1168, 13);
            btnDestino.Margin = new Padding(3, 2, 3, 2);
            btnDestino.Name = "btnDestino";
            btnDestino.Size = new Size(154, 22);
            btnDestino.TabIndex = 1;
            btnDestino.Text = "Seleccionar";
            btnDestino.UseVisualStyleBackColor = true;
            btnDestino.Click += BtnSeleccionarDestino_Click;
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDestino.ForeColor = SystemColors.HotTrack;
            lblDestino.Location = new Point(5, 17);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(40, 15);
            lblDestino.TabIndex = 0;
            lblDestino.Text = "label1";
            // 
            // gbDuplicados
            // 
            gbDuplicados.Controls.Add(BtnBuscar);
            gbDuplicados.Controls.Add(lstDuplicados);
            gbDuplicados.Location = new Point(10, 100);
            gbDuplicados.Margin = new Padding(3, 2, 3, 2);
            gbDuplicados.Name = "gbDuplicados";
            gbDuplicados.Padding = new Padding(3, 2, 3, 2);
            gbDuplicados.Size = new Size(1328, 444);
            gbDuplicados.TabIndex = 3;
            gbDuplicados.TabStop = false;
            gbDuplicados.Text = "Duplicados encontrados";
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(1182, 416);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(140, 23);
            BtnBuscar.TabIndex = 1;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // lstDuplicados
            // 
            lstDuplicados.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lstDuplicados.FullRowSelect = true;
            lstDuplicados.Location = new Point(5, 20);
            lstDuplicados.Margin = new Padding(3, 2, 3, 2);
            lstDuplicados.MultiSelect = false;
            lstDuplicados.Name = "lstDuplicados";
            lstDuplicados.Size = new Size(1317, 391);
            lstDuplicados.TabIndex = 0;
            lstDuplicados.UseCompatibleStateImageBehavior = false;
            lstDuplicados.View = View.Details;
            lstDuplicados.MouseDoubleClick += lstDuplicados_MouseDoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Origen";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Destino";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 554);
            Controls.Add(gbDuplicados);
            Controls.Add(gbDestino);
            Controls.Add(gbOrigen);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FrmPrincipal";
            Text = "Control de duplicados";
            gbOrigen.ResumeLayout(false);
            gbOrigen.PerformLayout();
            gbDestino.ResumeLayout(false);
            gbDestino.PerformLayout();
            gbDuplicados.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbOrigen;
        private Label lblOrigen;
        private Button btnSeleccionarOrigen;
        private GroupBox gbDestino;
        private Button btnDestino;
        private Label lblDestino;
        private GroupBox gbDuplicados;
        private ListView lstDuplicados;
        private Button BtnBuscar;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}