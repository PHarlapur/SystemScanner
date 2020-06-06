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
        DataSet ds = new DataSet();

        public XMLViewer()
        {
            InitializeComponent();
        }

        public XMLViewer(string path) : this()
        {
            ds.ReadXml(path);
            
            dgXMLView.DataSource = ds.Tables[0];
            dgXMLView.AutoGenerateColumns = true;
        }

        private void XMLViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
