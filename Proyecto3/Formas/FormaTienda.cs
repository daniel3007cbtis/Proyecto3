using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto3.Formas
{
    public partial class FormaTienda : Form
    {
        public FormaTienda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("Columna1", "Columna 1");
                dataGridView1.Columns.Add("Columna2", "Columna 2");
                dataGridView1.Columns.Add("Columna3", "Columna 3");
                dataGridView1.Columns.Add("Columna4", "Columna 4");
                dataGridView1.Columns.Add("Columna5", "Columna 5");
                dataGridView1.Columns.Add("Columna6", "Columna 6");
                dataGridView1.Columns.Add("Columna7", "Columna 7");
                dataGridView1.Columns.Add("Columna8", "Columna 8");
                
            }

            // Añade los datos ingresados en los 5 textboxes a la DataGridView
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormaMenu menu = new FormaMenu();
            menu.Show();
            Close();
        }
        private bool isEditable = false;

        private void button2_Click(object sender, EventArgs e)
        {
            if (isEditable)
            {
                // Si el DataGridView ya está en modo edición, se desactiva
                dataGridView1.ReadOnly = true;
                isEditable = false;
            }
            else
            {
                // Se muestra un MessageBox preguntando si se desea modificar la columna
                var result = MessageBox.Show("¿Quiere modificar la columna?", "Editar columna", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Si se desea modificar la columna, se activa el modo edición
                    dataGridView1.ReadOnly = false;
                    isEditable = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mensaje = "¿desea eliminar mensaje?";
            string titulo = "eliminar el registro";
            if (!(dataGridView1.CurrentRow is null))
            {
                if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "eliminado",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }




            }
            else
            {
                MessageBox.Show("debes seleccionar un renglon ", "eliminado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    }

