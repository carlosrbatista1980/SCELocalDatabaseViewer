using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
//using System.Text;
using System.Windows.Forms;
//using System.IO;
//using System.Data.Sql;
//using System.Data.SqlClient;
//using System.Data.SqlServerCe;
//using SCEsdf.NFCeLocalDBDataSetTableAdapters;
using System.Security.Principal;
using System.Security;



namespace SCEsdf
{
    public partial class Form1 : Form
    {

        static string sdf_conn_DataSorce = "";
        static string sdf_conn_Password = "";
        
        static WindowsIdentity user = WindowsIdentity.GetCurrent(); //pega a conta de usuário
        static WindowsPrincipal IsAdmin = new WindowsPrincipal(user); //passa a conta de usuário para o "principal"
        

        //this.nFCeTableAdapter.Fill(this.nFCeLocalDBDataSet.NFCe);
        
        public Form1()
        {
            InitializeComponent();            
            // if (IsAdmin.IsInRole(WindowsBuiltInRole.Administrator)) // testa se o usuário executou como administrador
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //nFCeTableAdapter.Connection.DataSource = "sadasafvsdvadva";
            progressBar1.Enabled = false;
            progressBar1.Visible = false;
            
        }

        public void CarregaSDF()
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "NFCeLocalDB|*.sdf";
            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = fd.FileName;
                sdf_conn_DataSorce = textBox1.Text;                
            }            
        }

        public void CarregaConsulta()
        {
            try
            {
                progressBar1.Visible = true;
                nFCeTableAdapter.Connection.ConnectionString = "Data Source=" + sdf_conn_DataSorce + ";" + sdf_conn_Password;
                nFCeTableAdapter.Fill(nFCeLocalDBDataSet.NFCe);
            }
            catch (Exception ex)
            {
                progressBar1.Visible = false;
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }

            finally
            {
                progressBar1.Visible = false;
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            CarregaSDF();
    
            if (textBox1.Text == "")
            {
                MessageBox.Show("Carregue o arquivo SDF primeiro", "Carregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaSDF();
            }
            else
            {
                CarregaConsulta();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Visible = true;
                DialogResult result = MessageBox.Show("Deseja salvar as modificações ?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes && nFCeLocalDBDataSet.NFCe.Count != 0)
                {
                    try
                    {
                        nFCeTableAdapter.Update(nFCeLocalDBDataSet.NFCe);
                        MessageBox.Show("Modificações salvas com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregaConsulta();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("O banco de dados não está carregado!");
                }

                

            }
            catch (Exception ex)
            {
                progressBar1.Visible = false;
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            finally
            {
                progressBar1.Visible = false;
            }
        }


        void EditarVisual(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell != null && nFCeLocalDBDataSet.NFCe.Count != 0)
            {
                dataGridView1.CurrentCell.Style.BackColor = Color.LightCoral; // troca a cor de fundo da celula
                //dataGridView1.CurrentCell.Style.ForeColor = Color.Red;  // troca a cor da letra
            }
            
        }

        void SalvarAoSair(object sender, FormClosingEventArgs e)
        {
            if (nFCeLocalDBDataSet.NFCe.Count != 0)
            {
                DialogResult result = MessageBox.Show("Deseja salvar as modificações ?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        nFCeTableAdapter.Update(nFCeLocalDBDataSet.NFCe);
                        MessageBox.Show("Modificações salvas com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
    }
}
