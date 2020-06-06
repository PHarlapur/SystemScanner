using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class XMLViewer : Form
    {
        public XMLViewer()
        {
            InitializeComponent();
        }

        private void XMLViewer_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("D:\\data.xml");
            //dgXMLView.DataSource = ds;

            dgXMLView.DataSource = ds.Tables[0];
            dgXMLView.AutoGenerateColumns = true;

        }
    }
}
