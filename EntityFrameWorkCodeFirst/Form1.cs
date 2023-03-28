using EntityFrameWorkCodeFirst.DbContex_Model_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameWorkCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           Ornek_Db db = new Ornek_Db();
           // db.Database.Create();
            dataGridView1.DataSource = db.Database;// Bu şekilde de tablo otomatik oluşturulur

        }
    }
}
