using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

// 查询，客户

namespace coalgasOS
{
    public partial class FormSelClient : FormClass
    {

        public FormSelClient()
        {
            InitializeComponent();
        }

        String nowSel = DataClass.selData;

        private void FormSelClient_Load(object sender, EventArgs e)
        {

            initDataGridView();

        }

        // 切换查询
        // 切换查询
        // 切换查询
        private void button1_Click(object sender, EventArgs e)
        {
            nowSel = "coalgas";
            initDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nowSel = "client";
            initDataGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nowSel = "staff";
            initDataGridView();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nowSel = "supplier";
            initDataGridView();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nowSel = "out_s";
            initDataGridView();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            nowSel = "into_s";
            initDataGridView();
        }

        // 查找
        // 查找
        // 查找
        private void buttonFind_Click(object sender, EventArgs e)
        {

            String keywords;
            String sql1 = "";

            if (checkBox1.Checked)
            {
                // 模糊查找
                keywords = "like '%" + textBoxFind.Text +"%";

            }
            else
            {
                // 精确查找
                keywords = "= '" + textBoxFind.Text;

            }

            switch (nowSel)
            {
                case "coalgas":
                    sql1 = "select * from coalgas where coalgas_id " + keywords + "' or coalgas_name " + keywords + "' or coalgas_into_pay " + keywords + "' or coalgas_out_pay " + keywords + "' or coalgas_num " + keywords + "' or coalgas_note " + keywords + "'";
                    break;

                case "client":
                    sql1 = "select * from client where client_id " + keywords + "' or client_name " + keywords + "' or client_phone " + keywords + "' or client_add " + keywords + "' or client_note " + keywords + "'";
                    break;

                case "staff":
                    sql1 = "select * from staff where staff_id " + keywords + "' or staff_name " + keywords + "' or staff_phone " + keywords + "' or staff_add " + keywords + "' or staff_note " + keywords + "'";
                    break;

                case "supplier":
                    sql1 = "select * from supplier where supplier_id " + keywords + "' or supplier_name " + keywords + "' or supplier_phone " + keywords + "' or supplier_add " + keywords + "' or supplier_note " + keywords + "'";
                    break;

                case "out_s":
                    sql1 = "select * from out_s where out_id " + keywords + "' or client_id " + keywords + "' or staff_id " + keywords + "' or coalgas_id " + keywords + "' or out_time " + keywords + "' or out_num " + keywords + "' or out_pay " + keywords + "' or out_note " + keywords + "'";
                    break;

                case "into_s":
                    sql1 = "select * from into_s where into_id " + keywords + "' or supplier_id " + keywords + "' or coalgas_id " + keywords + "' or into_time " + keywords + "' or into_num " + keywords + "' or into_pay " + keywords + "' or into_note " + keywords + "'";
                    break;
            }

            try
            {

                connection.Open();  //打开数据库连接

                SqlCommand command = new SqlCommand(sql1, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataSet myDataSet = new DataSet();

                dataAdapter.Fill(myDataSet, "findTab");

                //使用DataSet绑定时，必须同时指明DateMember 
                this.dataGridView.DataSource = myDataSet;
                this.dataGridView.DataMember = "findTab";

                beautifyDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close(); //关闭数据库连接
            }

        }

        /// <summary>
        /// 查询操作,从数据库获取数据,并填充到DataGridView
        /// </summary>
        private void initDataGridView()
        {

            textBoxFind.Text = "";  //清空查找输入框

            try
            {

                connection.Open();  //打开数据库连接

                String sql1 = "select * from " + nowSel;

                SqlCommand command = new SqlCommand(sql1, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataSet myDataSet = new DataSet();

                dataAdapter.Fill(myDataSet, "selTab");

                //使用DataSet绑定时，必须同时指明DateMember 
                this.dataGridView.DataSource = myDataSet;
                this.dataGridView.DataMember = "selTab";

                beautifyDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close(); //关闭数据库连接
            }

        }

        /// <summary>
        /// 美化 DataGridView
        /// </summary>
        private void beautifyDataGridView()
        {

            switch (nowSel)
            {
                case "coalgas":

                    this.Text = "商品查询";

                    //改变DataGridView的表头
                    this.dataGridView.Columns[0].HeaderText = "编号";
                    this.dataGridView.Columns[1].HeaderText = "名称";
                    this.dataGridView.Columns[2].HeaderText = "进货价";
                    this.dataGridView.Columns[3].HeaderText = "售价";
                    this.dataGridView.Columns[4].HeaderText = "库存";
                    this.dataGridView.Columns[5].HeaderText = "备注";

                    //自适应DataGridView的列宽度
                    dataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    break;

                case "client":

                    this.Text = "客户查询";

                    //改变DataGridView的表头
                    this.dataGridView.Columns[0].HeaderText = "编号";
                    this.dataGridView.Columns[1].HeaderText = "名称";
                    this.dataGridView.Columns[2].HeaderText = "电话";
                    this.dataGridView.Columns[3].HeaderText = "地址";
                    this.dataGridView.Columns[4].HeaderText = "备注";

                    break;

                case "staff":

                    this.Text = "员工查询";

                    //改变DataGridView的表头
                    this.dataGridView.Columns[0].HeaderText = "编号";
                    this.dataGridView.Columns[1].HeaderText = "名称";
                    this.dataGridView.Columns[2].HeaderText = "电话";
                    this.dataGridView.Columns[3].HeaderText = "地址";
                    this.dataGridView.Columns[4].HeaderText = "备注";

                    break;

                case "supplier":

                    this.Text = "供应商查询";

                    //改变DataGridView的表头
                    this.dataGridView.Columns[0].HeaderText = "编号";
                    this.dataGridView.Columns[1].HeaderText = "名称";
                    this.dataGridView.Columns[2].HeaderText = "电话";
                    this.dataGridView.Columns[3].HeaderText = "地址";
                    this.dataGridView.Columns[4].HeaderText = "备注";
                    break;

                case "out_s":

                    this.Text = "售货查询";

                    //改变DataGridView的表头
                    this.dataGridView.Columns[0].HeaderText = "售货编号";
                    this.dataGridView.Columns[1].HeaderText = "客户编号";
                    this.dataGridView.Columns[2].HeaderText = "员工编号";
                    this.dataGridView.Columns[3].HeaderText = "煤气编号";
                    this.dataGridView.Columns[4].HeaderText = "时间";
                    this.dataGridView.Columns[5].HeaderText = "数量";
                    this.dataGridView.Columns[6].HeaderText = "是否结账";
                    this.dataGridView.Columns[7].HeaderText = "备注";

                    //自适应DataGridView的列宽度
                    dataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    break;

                case "into_s":

                    this.Text = "进货查询";

                    //改变DataGridView的表头
                    this.dataGridView.Columns[0].HeaderText = "进货编号";
                    this.dataGridView.Columns[1].HeaderText = "供应商编号";
                    this.dataGridView.Columns[2].HeaderText = "煤气编号";
                    this.dataGridView.Columns[3].HeaderText = "时间";
                    this.dataGridView.Columns[4].HeaderText = "数量";
                    this.dataGridView.Columns[5].HeaderText = "是否结账";
                    this.dataGridView.Columns[6].HeaderText = "备注";

                    //自适应DataGridView的列宽度
                    dataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    break;
            }

            //自适应DataGridView的列宽度
            dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            /*
            //设置DataGridView的列宽度
            dataGridView.Columns[0].Width = 100;
            dataGridView.Columns[1].Width = 200;
            dataGridView.Columns[2].Width = 100;
            dataGridView.Columns[3].Width = 100;
            dataGridView.Columns[4].Width = 100;
            dataGridView.Columns[5].Width = 100;
            */

            //不显示出dataGridView的最后一行空白
            dataGridView.AllowUserToAddRows = false;

            //不允许在dataGridView上直接编辑
            dataGridView.ReadOnly = true;

            //设置控件选中选中的模式  
            //单击单元格或行标题可以选中整行  
            this.dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

    }
}
