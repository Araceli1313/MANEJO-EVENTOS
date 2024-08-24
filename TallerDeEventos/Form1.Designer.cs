namespace TallerDeEventos
{
    partial class ControlTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlTareas));
            TxtIngresarTarea = new TextBox();
            PnlTareasEjecutar = new FlowLayoutPanel();
            PnlTareasProceso = new FlowLayoutPanel();
            PnlTareasFinalizadas = new FlowLayoutPanel();
            tareasRealizar = new Label();
            tareasProceso = new Label();
            tareasFinalizadas = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            tableroTarea = new Label();
            comboSelector = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // TxtIngresarTarea
            // 
            TxtIngresarTarea.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtIngresarTarea.Location = new Point(56, 65);
            TxtIngresarTarea.Margin = new Padding(3, 2, 3, 2);
            TxtIngresarTarea.Name = "TxtIngresarTarea";
            TxtIngresarTarea.PlaceholderText = "Ingresar Tareas";
            TxtIngresarTarea.Size = new Size(276, 22);
            TxtIngresarTarea.TabIndex = 0;
            TxtIngresarTarea.TextAlign = HorizontalAlignment.Center;
            TxtIngresarTarea.KeyDown += TxtIngresarTarea_KeyDown;
            // 
            // PnlTareasEjecutar
            // 
            PnlTareasEjecutar.AutoScroll = true;
            PnlTareasEjecutar.BackColor = Color.LightGray;
            PnlTareasEjecutar.BorderStyle = BorderStyle.FixedSingle;
            PnlTareasEjecutar.FlowDirection = FlowDirection.TopDown;
            PnlTareasEjecutar.Location = new Point(56, 186);
            PnlTareasEjecutar.Margin = new Padding(3, 2, 3, 2);
            PnlTareasEjecutar.Name = "PnlTareasEjecutar";
            PnlTareasEjecutar.Size = new Size(206, 312);
            PnlTareasEjecutar.TabIndex = 2;
            PnlTareasEjecutar.WrapContents = false;
            // 
            // PnlTareasProceso
            // 
            PnlTareasProceso.AutoScroll = true;
            PnlTareasProceso.BackColor = Color.LightGray;
            PnlTareasProceso.BorderStyle = BorderStyle.FixedSingle;
            PnlTareasProceso.FlowDirection = FlowDirection.TopDown;
            PnlTareasProceso.Location = new Point(279, 186);
            PnlTareasProceso.Margin = new Padding(3, 2, 3, 2);
            PnlTareasProceso.Name = "PnlTareasProceso";
            PnlTareasProceso.Size = new Size(206, 312);
            PnlTareasProceso.TabIndex = 3;
            PnlTareasProceso.WrapContents = false;
            // 
            // PnlTareasFinalizadas
            // 
            PnlTareasFinalizadas.AutoScroll = true;
            PnlTareasFinalizadas.BackColor = Color.LightGray;
            PnlTareasFinalizadas.BorderStyle = BorderStyle.FixedSingle;
            PnlTareasFinalizadas.FlowDirection = FlowDirection.TopDown;
            PnlTareasFinalizadas.Location = new Point(509, 186);
            PnlTareasFinalizadas.Margin = new Padding(3, 2, 3, 2);
            PnlTareasFinalizadas.Name = "PnlTareasFinalizadas";
            PnlTareasFinalizadas.Size = new Size(206, 312);
            PnlTareasFinalizadas.TabIndex = 4;
            PnlTareasFinalizadas.WrapContents = false;
            // 
            // tareasRealizar
            // 
            tareasRealizar.AutoSize = true;
            tareasRealizar.BorderStyle = BorderStyle.FixedSingle;
            tareasRealizar.Font = new Font("Verdana", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            tareasRealizar.Location = new Point(90, 156);
            tareasRealizar.Name = "tareasRealizar";
            tareasRealizar.Size = new Size(134, 18);
            tareasRealizar.TabIndex = 5;
            tareasRealizar.Text = "Tareas a Ejecutar ";
            tareasRealizar.TextAlign = ContentAlignment.TopCenter;
            // 
            // tareasProceso
            // 
            tareasProceso.AutoSize = true;
            tareasProceso.BorderStyle = BorderStyle.FixedSingle;
            tareasProceso.Font = new Font("Verdana", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            tareasProceso.Location = new Point(318, 156);
            tareasProceso.Name = "tareasProceso";
            tareasProceso.Size = new Size(133, 18);
            tareasProceso.TabIndex = 6;
            tareasProceso.Text = "Tareas en Proceso";
            tareasProceso.TextAlign = ContentAlignment.TopCenter;
            // 
            // tareasFinalizadas
            // 
            tareasFinalizadas.AutoSize = true;
            tareasFinalizadas.BorderStyle = BorderStyle.FixedSingle;
            tareasFinalizadas.Font = new Font("Verdana", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            tareasFinalizadas.Location = new Point(549, 156);
            tareasFinalizadas.Name = "tareasFinalizadas";
            tareasFinalizadas.Size = new Size(131, 18);
            tareasFinalizadas.TabIndex = 7;
            tareasFinalizadas.Text = "Tareas Finalizadas";
            tareasFinalizadas.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(131, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(358, 106);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(590, 106);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(55, 47);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // tableroTarea
            // 
            tableroTarea.AutoSize = true;
            tableroTarea.Font = new Font("Verdana", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tableroTarea.ForeColor = SystemColors.ButtonHighlight;
            tableroTarea.Location = new Point(217, 12);
            tableroTarea.Name = "tableroTarea";
            tableroTarea.Size = new Size(329, 32);
            tableroTarea.TabIndex = 11;
            tableroTarea.Text = "TABLERO DE TAREAS";
            // 
            // comboSelector
            // 
            comboSelector.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboSelector.FormattingEnabled = true;
            comboSelector.ImeMode = ImeMode.NoControl;
            comboSelector.Location = new Point(509, 64);
            comboSelector.Name = "comboSelector";
            comboSelector.Size = new Size(206, 22);
            comboSelector.TabIndex = 12;
            comboSelector.SelectedIndexChanged += comboSelector_SelectedIndexChanged;
            // 
            // ControlTareas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(775, 534);
            Controls.Add(comboSelector);
            Controls.Add(tableroTarea);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(PnlTareasFinalizadas);
            Controls.Add(tareasFinalizadas);
            Controls.Add(tareasProceso);
            Controls.Add(tareasRealizar);
            Controls.Add(PnlTareasProceso);
            Controls.Add(PnlTareasEjecutar);
            Controls.Add(TxtIngresarTarea);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ControlTareas";
            Text = "Control de Tareas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtIngresarTarea;
        private FlowLayoutPanel PnlTareasEjecutar;
        private FlowLayoutPanel PnlTareasProceso;
        private FlowLayoutPanel PnlTareasFinalizadas;
        private Label tareasRealizar;
        private Label tareasProceso;
        private Label tareasFinalizadas;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label tableroTarea;
        private ComboBox comboSelector;
    }
}
