using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

namespace coalgasOS
{
    public class FormClass : Form
    {

        //server地址， 数据库名， 连接方式

        //public SqlConnection connection = new SqlConnection("server=(local);database=coalgasDB;Trusted_Connection=Yes;"); //server地址， 数据库名， 连接方式
        public SqlConnection connection = new SqlConnection("server=(local);database=coalgasDB;user=sa;pwd=123456;");

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormClass
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "FormClass";
            this.Load += new System.EventHandler(this.FormClass_Load);
            this.ResumeLayout(false);

        }

        private void FormClass_Load(object sender, EventArgs e)
        {

        }

    }
}
