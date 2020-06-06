using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;

namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {

        DataSet ds = new DataSet();
        public frmLogin()
        {
            InitializeComponent();
            ds.ReadXml(txtFilePath.Text);
            //dgXMLView.DataSource = ds;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            using (var client = new SshClient("","",""))
            {
                try
                {
                    client.Connect();

                   // lblResults.Text = "Successfully connected";

                    SshCommand cmd = client.RunCommand("exec ifconfig");

                   // lblResults.Text = lblResults.Text.ToString() + "\n Ran Command connected";

                   // lblResults.Text = lblResults.Text.ToString() + "\n Ran Command Result:  " + cmd.Result;

                    client.Disconnect();
                    client.Dispose();

                    //lblResults.Text = lblResults.Text.ToString() +  "\n Successfully disconnected";

                }
                catch (Exception)
                {

                    throw;
                }
                
               
                
            }
        }

        private void xMLViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XMLViewer xv = new XMLViewer();
            xv.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pbar.Maximum = ds.Tables[0].Rows.Count;
            pbar.Minimum = 0;
            pbar.Step = 1;

        }

        private void btnScanSystem_Click(object sender, EventArgs e)
        {
            pbar.Value = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                using (var client = new SshClient(dr["ip"].ToString(), dr["username"].ToString(), dr["password"].ToString()))
                {
                    try
                    {
                        client.Connect();


                    }
                    catch (Exception ex)
                    {
                        dr["Results"] = ex.ToString();
                    }

                    SshCommand cmd = client.RunCommand(dr["Command"].ToString());


                        dr["Results"] = cmd.Result;
                        
                        client.Disconnect();
                        client.Dispose();

                        //lblResults.Text = lblResults.Text.ToString() +  "\n Successfully disconnected";
                   

                }

                pbar.PerformStep();
                
            }

            cbSystems.DataSource = ds.Tables[0];
            cbSystems.ValueMember = "ip";
            cbSystems.DisplayMember = "ip";

           

        }

        private void cbSystems_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            // Save the selected employee's name, because we will remove
            // the employee's name from the list.
            //string ip = comboBox.SelectedItem.ToString();
            string ip = ((System.Data.DataRowView)comboBox.SelectedItem).Row.ItemArray[0].ToString();

            DataRow[] foundRows;
            foundRows = ds.Tables[0].Select(" ip Like '"+ip+"%'");
            if(foundRows.Length >0)
            lblResults.Text = foundRows[0]["Results"].ToString();
        }

        private void btnViewXml_Click(object sender, EventArgs e)
        {
            XMLViewer newWindow = new XMLViewer(txtFilePath.Text);
            newWindow.Show();
        }
    }
}
