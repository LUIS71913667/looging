using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Loging0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-7LDGQBD");

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            String consulta = "select * from usuario where usuario='"+textBox1.Text+"' and contraseña='"+textBox2.Text+"'";
            SqlCommand comando = new SqlCommand(consulta,conexion);
            SqlDataReader lector; 
            lector = comando.ExecuteReader();

            if (lector.HasRows == true) 
            {
                Form2 frmbienvenido = new Form2();
                this.Hide();
                frmbienvenido.Show();
            }
            else {
                
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
            conexion.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
