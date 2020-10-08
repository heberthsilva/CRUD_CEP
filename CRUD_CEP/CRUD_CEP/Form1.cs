using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD_CEP
{
    public partial class Form1 : Form
    {

        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;

        String strSQL;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=cad_imoveis;Uid=sa;Pwd=123456;");

                strSQL = "INSERT INTO cad_imoveis (cep,logradouro,numero,cidade,uf) VALUES (@CEP,@END,@NUM,@CIDADE,@UF)";

                comando = new MySqlCommand(strSQL,conexao);

                comando.Parameters.AddWithValue("@CEP", Box_Cep.Text);
                comando.Parameters.AddWithValue("@END", BoxLogradouro.Text);
                comando.Parameters.AddWithValue("@NUM", BoxNumero.Text);
                comando.Parameters.AddWithValue("@CIDADE", BoxCidade.Text);
                comando.Parameters.AddWithValue("@UF", BoxUF.Text);

                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
                Box_Cep.Clear();
                BoxLogradouro.Clear();
                BoxNumero.Clear();
                BoxCidade.Clear();
                BoxUF.Clear();
                
            }




        }
    }
}
