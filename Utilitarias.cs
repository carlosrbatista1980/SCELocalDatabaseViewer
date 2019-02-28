using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SCELocalDatabaseViewer
{
    class Utilitarias
    {
        NFCeLocalDBDataSetTableAdapters.NFCeTableAdapter NFC_ta = new NFCeLocalDBDataSetTableAdapters.NFCeTableAdapter();
        NFCeLocalDBDataSet NFC_ds = new NFCeLocalDBDataSet();

        string connPassword = "";
        //nFCeTableAdapter.Connection.ConnectionString = "Data Source=" + sdf_conn_DataSorce + ";" + sdf_conn_Password;
         //       nFCeTableAdapter.Fill(nFCeLocalDBDataSet.NFCe);

        public bool AbrirSDF(string connString)
        {
            try
            {
                NFC_ta.Connection.ConnectionString = "Data Source=" + connString + ";" + connPassword;
                NFC_ta.Fill(NFC_ds.NFCe);
                if (NFC_ds.NFCe.Count < 1)
                {
                    MessageBox.Show("O banco de dados está vazio!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                    
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }

        public bool SalvarSDF()
        {
            try
            {
                NFC_ta.Update(NFC_ds.NFCe);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao Salvar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        public string BancoSDF_Path
        {
            get
            {
                string path = "";
                OpenFileDialog fd = new OpenFileDialog();
                fd.Filter = "NFCeLocalDB|*.sdf";
                if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    path = fd.FileName;                    
                }

                return path;
            }
        }


    }
}
