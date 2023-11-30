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
    public partial class FormaEmpleados : Form
    {
        public FormaEmpleados()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormaEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormaMenu menu = new FormaMenu();
            menu.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string apellidos = textBox2.Text;
            string curp = textBox8.Text;
            string telefono = textBox9.Text;
            string textbox3 = textBox3.Text;
            string textbox4 = textBox4.Text;
            string textbox5 = textBox5.Text;
            string textbox6 = textBox6.Text;
            string textbox7 = textBox7.Text;

            if (nombre.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c)))
            {
                MessageBox.Show("El campo Nombre solo debe contener letras y espacios.");
                return;
            }

            if (apellidos.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c)))
            {
                MessageBox.Show("El campo Apellidos solo debe contener letras y espacios.");
                return;
            }

            if (curp.Length != 18)
            {
                MessageBox.Show("El campo CURP debe tener exactamente 18 caracteres.");
                return;
            }

            if (telefono.Length != 10 || !telefono.All(char.IsDigit))
            {
                MessageBox.Show("El campo Teléfono debe tener exactamente 10 dígitos y contener solo dígitos.");
                return;
            }

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
                dataGridView1.Columns.Add("Columna9", "Columna 9");
            }

            dataGridView1.Rows.Add(nombre, apellidos, textbox3, textbox4, textbox5, textbox6, textbox7, curp, telefono);
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
    }
    }

