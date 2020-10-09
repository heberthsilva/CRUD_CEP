using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=cad_imoveis;Uid=sa;Pwd=123456;");

                strSQL = "SELECT * FROM cad_imoveis WHERE ID = @ID";

                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@ID", BoxID.Text);


                conexao.Open();

                dr = comando.ExecuteReader();

                while (dr.Read()) 
                {

                    Box_Cep.Text = Convert.ToString(dr["cep"]);
                    BoxLogradouro.Text = Convert.ToString(dr["logradouro"]);
                    BoxNumero.Text = Convert.ToString(dr["numero"]);
                    BoxCidade.Text = Convert.ToString(dr["cidade"]);
                    BoxUF.Text = Convert.ToString(dr["uf"]);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {   //fechar conexão com o BD
                conexao.Close();
                //Limpar Strings.
                conexao = null;
                comando = null;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=cad_imoveis;Uid=sa;Pwd=123456;");

                strSQL = "SELECT * FROM cad_imoveis ";

                da = new MySqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();

                da.Fill(dt);

                GridView.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {   //fechar conexão com o BD
                conexao.Close();
                //Limpar Strings.
                conexao = null;
                comando = null;

            }

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
            {   //fechar conexão com o BD
                conexao.Close();
                //Limpar Strings.
                conexao = null;
                comando = null;
                //Limpar os campos de texto
                Box_Cep.Clear();
                BoxLogradouro.Clear();
                BoxNumero.Clear();
                BoxCidade.Clear();
                BoxUF.Clear();

                MessageBox.Show("Inserido com Sucesso");
            }




        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=cad_imoveis;Uid=sa;Pwd=123456;");

                strSQL = "UPDATE cad_imoveis SET cep = @CEP , logradouro = @END , numero = @NUM , cidade = @CIDADE , uf = @UF  WHERE id= @ID";

                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@ID", BoxID.Text);
                comando.Parameters.AddWithValue("@CEP", Box_Cep.Text);
                comando.Parameters.AddWithValue("@END", BoxLogradouro.Text);
                comando.Parameters.AddWithValue("@NUM", BoxNumero.Text);
                comando.Parameters.AddWithValue("@CIDADE", BoxCidade.Text);
                comando.Parameters.AddWithValue("@UF", BoxUF.Text);

                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {   //fechar conexão com o BD
                conexao.Close();
                //Limpar Strings.
                conexao = null;
                comando = null;
                //Limpar os campos de texto
                Box_Cep.Clear();
                BoxLogradouro.Clear();
                BoxNumero.Clear();
                BoxCidade.Clear();
                BoxUF.Clear();

                MessageBox.Show("Alterado com Sucesso");
            }

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=cad_imoveis;Uid=sa;Pwd=123456;");

                strSQL = "DELETE FROM cad_imoveis  WHERE id= @ID";

                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@ID", BoxID.Text);


                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {   //fechar conexão com o BD
                conexao.Close();
                //Limpar Strings.
                conexao = null;
                comando = null;
                //Limpar os campos de texto
                Box_Cep.Clear();
                BoxLogradouro.Clear();
                BoxNumero.Clear();
                BoxCidade.Clear();
                BoxUF.Clear();

                MessageBox.Show("Deletado com Sucesso");
            }
        }

        private void buttonExibir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=cad_imoveis;Uid=sa;Pwd=123456;");

                strSQL = "SELECT * FROM cad_imoveis ";

                da = new MySqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();

                da.Fill(dt);

                GridView.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {   //fechar conexão com o BD
                conexao.Close();
                //Limpar Strings.
                conexao = null;
                comando = null;

            }
        }

        private void LocalizaCep_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + Box_Cep.Text + "/json/");
            request.AllowAutoRedirect = false;
            HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

            if (ChecaServidor.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Servidor VIACEP indisponível");
                return; // Sai da rotina
            }

            using (Stream webStream = ChecaServidor.GetResponseStream())
            {
                if (webStream != null)
                {
                    using (StreamReader responseReader = new StreamReader(webStream))
                    {
                        string response = responseReader.ReadToEnd();
                        response = Regex.Replace(response, "[{},]", string.Empty);
                        response = response.Replace("\"", "");

                        String[] substrings = response.Split('\n');

                        int cont = 0;
                        foreach (var substring in substrings)
                        {
                            if (cont == 1)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                if (valor[0] == "  erro")
                                {
                                    MessageBox.Show("CEP não encontrado");
                                    Box_Cep.Focus();
                                    return;
                                }
                            }

                            //Logradouro
                            if (cont == 2)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                BoxLogradouro.Text = valor[1];
                            }

                            //Cidade
                            if (cont == 5)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                BoxCidade.Text = valor[1];
                            }

                            //Estado (UF)
                            if (cont == 6)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                BoxUF.Text = valor[1];
                            }

                            cont++;
                        }
                    }
                }
            }
        }

        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) //verifica se não clicou no header da coluna 
            {
                //Considerando que a Cell 0 nunca será nulo, não fiz a validação
                Box_Cep.Text = GridView.CurrentRow.Cells[1].Value.ToString();
                BoxLogradouro.Text = GridView.CurrentRow.Cells[2].Value.ToString();
                BoxNumero.Text = GridView.CurrentRow.Cells[3].Value.ToString();
                BoxCidade.Text = GridView.CurrentRow.Cells[4].Value.ToString();
                BoxCidade.Text = GridView.CurrentRow.Cells[5].Value.ToString();
            }
        }
    }
}
