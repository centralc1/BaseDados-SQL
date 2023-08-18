using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


//Sql Server CE
using System.Data.SqlServerCe;

//SQLite
using System.Data.SQLite;

//MySQL
using MySql.Data.MySqlClient;

namespace BaseDados1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            #region SQL Server CE

            string BaseDados1 = Application.StartupPath + @"/db/DBSQLServer.sdf";
            string strConnection = @"DataSource = " + BaseDados1 + "; Password = '1234'";

            SqlCeEngine db = new SqlCeEngine(strConnection);

            if (!File.Exists(BaseDados1))
            {
                db.CreateDatabase();
            }

            db.Dispose();

            SqlCeConnection conexao = new SqlCeConnection(strConnection);
            //conexao.ConnectionString = strConnection;   

            try
            {
                conexao.Open();
                labelResultado.Text = "Conectado Sql Server CE";
            }
            catch (Exception ex)
            {
                labelResultado.Text = "Erro ao Conectar Sql Server CE /n" + ex;
            }
            finally
            {
                conexao.Close();
            }
            #endregion

            #region SQLite

            //string BaseDados1 = Application.StartupPath + @"/db/DBSQLite.db";
            //string strConnection = @"Data Source = " + BaseDados1 + "; Version = 3";

            //if (!File.Exists(BaseDados1))
            //{
            //    SQLiteConnection.CreateFile(BaseDados1);   
            //}

            //SQLiteConnection conexao = new SQLiteConnection(strConnection);
            ////conexao.ConnectionString = strConnection;   

            //try
            //{
            //    conexao.Open();
            //    labelResultado.Text = "Conectado SQLite";
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = "Erro ao Conectar SQLite /n" + ex;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region MySql
            //string strConnection = "server=127.0.0.1;User Id=root;password=logan";
            ////string strConnection2 = "server=127.0.0.1;User Id=root;password=logan";

            //MySqlConnection conexao = new MySqlConnection(strConnection);
            ////conexao.ConnectionString = strConnection;

            //try
            //{
            //    conexao.Open();
            //    labelResultado.Text = "Conectado MySQL";

            //    MySqlCommand comando = new MySqlCommand();
            //    comando.Connection = conexao;
            //    comando.CommandText = "CREATE DATABASE IF NOT EXISTS João Vitor_db";

            //    comando.ExecuteNonQuery();
            //    labelResultado.Text = "Base de Dados Criada com sucesso.";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = "Erro ao Conectar MySQL /n" + ex;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion
        }
    }
}
