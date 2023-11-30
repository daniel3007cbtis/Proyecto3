using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto3.Formas;

namespace Proyecto3
{
    public partial class Form1 : Form
    {
        private int attempts;
        public Form1()
        {
            InitializeComponent();
            attempts = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Error: Campos incorrectos, acceso denegado. Asegúrese de completar todos los campos.");
                return;
            }

            if (textBox1.Text.Length < 3)
            {
                MessageBox.Show("El usuario debe tener al menos tres caracteres.");
                return;
            }

            // Verificar que la contraseña cumpla con los requisitos
            if (textBox2.Text.Length < 6 || textBox2.Text.Length > 15 || !textBox2.Text.Any(char.IsLetter) || !textBox2.Text.Any(char.IsDigit))
            {
                MessageBox.Show("La contraseña debe tener entre 6 y 15 caracteres y contener letras y números.");
                return;
            }

            if (textBox1.Text == "daniel22@gmail.com" && textBox2.Text == "messi100")
            {
                // Abre la nueva forma (FormaMenu) si las credenciales son correctas
                FormaMenu formaMenu = new FormaMenu();
                formaMenu.Show();
                this.Hide(); // Oculta la forma actual si se abre la FormaMenu
            }
            else
            {
                attempts--;
                MessageBox.Show($"Los campos ingresados no son correctos. Intentos restantes: {attempts}");

                if (attempts == 0)
                {
                    Close();
                }
            }

        }
    }
}
