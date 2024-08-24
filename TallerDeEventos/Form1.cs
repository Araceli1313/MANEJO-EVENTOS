using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TallerDeEventos.Clases;

namespace TallerDeEventos
{
    public partial class ControlTareas : Form
    {
        List<Tarea> Tareas = new List<Tarea>();
        private FlowLayoutPanel pnlSelect;

        public ControlTareas()
        {
            InitializeComponent();
            ConfigurarEventosDragDrop(PnlTareasEjecutar);
            ConfigurarEventosDragDrop(PnlTareasProceso);
            ConfigurarEventosDragDrop(PnlTareasFinalizadas);


            comboSelector.Items.Add("Tareas por Ejecutar");
            comboSelector.Items.Add("Tareas en Proceso");
            comboSelector.Items.Add("Tareas Finalizadas");


            comboSelector.SelectedIndex = 0;

            comboSelector.SelectedIndexChanged += comboSelector_SelectedIndexChanged;
        }

        private void ConfigurarEventosDragDrop(FlowLayoutPanel panel)
        {
            panel.AllowDrop = true;
            panel.DragEnter += new DragEventHandler(Pnl_DragEnter);
            panel.DragDrop += new DragEventHandler(Pnl_DragDrop);
        }

        private void TxtIngresarTarea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TxtIngresarTarea.Text.Trim() == "")
                {
                    MessageBox.Show("Por favor ingrese la tarea");
                    return;
                }

                Tarea nuevatarea = new Tarea(TxtIngresarTarea.Text, "Pendiente");

                Tareas.Add(nuevatarea);

                Label etiquetaTarea = new Label
                {
                    Text = nuevatarea.nombre,
                    AutoSize = true,
                    MinimumSize = new Size(198, 30),
                    MaximumSize = new Size(198, 30),
                    Padding = new Padding(5),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White,
                    Size = new Size(198, 30)
                };
      
                etiquetaTarea.MouseDown += new MouseEventHandler(etiquetaTarea_MouseDown);
                etiquetaTarea.DoubleClick += new EventHandler(etiquetaTarea_DoubleClick); 

                pnlSelect.Controls.Add(etiquetaTarea);

                TxtIngresarTarea.Clear();

                e.SuppressKeyPress = true;
            }
        }

        private void etiquetaTarea_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label tarea = sender as Label;

                if (tarea != null)
                {
                    tarea.DoDragDrop(tarea, DragDropEffects.Move);
                }
            }
        }

        private void etiquetaTarea_DoubleClick(object sender, EventArgs e)
        {
            Label tarea = sender as Label;
            if (tarea != null)
            {
                FlowLayoutPanel parentPanel = tarea.Parent as FlowLayoutPanel;
                if (parentPanel != null)
                {
                    parentPanel.Controls.Remove(tarea);
                }
            }
        }

        private void Pnl_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Label)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void Pnl_DragDrop(object sender, DragEventArgs e)
        {
            Label tarea = e.Data.GetData(typeof(Label)) as Label;
            if (tarea != null)
            {
                FlowLayoutPanel targetPanel = sender as FlowLayoutPanel;
                if (targetPanel != null)
                {
                    if (targetPanel == PnlTareasEjecutar)
                    {
                        tarea.BackColor = Color.White;
                    }
                    else if (targetPanel == PnlTareasProceso)
                    {
                        tarea.BackColor = Color.White;
                    }
                    else if (targetPanel == PnlTareasFinalizadas)
                    {
                        tarea.BackColor = Color.White;
                    }

                    targetPanel.Controls.Add(tarea);
                    tarea.BringToFront();
                }
            }
        }

        private void comboSelector_SelectedIndexChanged(object sender, EventArgs e)

        {
            switch (comboSelector.SelectedIndex)
            {
                case 0:
                    pnlSelect = PnlTareasEjecutar;
                    break;
                case 1:
                    pnlSelect = PnlTareasProceso;
                    break;
                case 2:
                    pnlSelect = PnlTareasFinalizadas;
                    break;
            }
        }


        }
    }
