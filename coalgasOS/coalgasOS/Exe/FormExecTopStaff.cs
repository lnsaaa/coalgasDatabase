﻿using System;
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

// 创建存储过程统计每个送气员工指定月份送气的数量；

namespace coalgasOS
{
    public partial class FormExecTopStaff : FormClass
    {
        public FormExecTopStaff()
        {
            InitializeComponent();
        }

        string year = "2018";
        string month = "1";

        private void initDataGridView()
        {
            try
            {

                connection.Open();  //打开数据库连接

                String sql1 = "exec top_staff '" + year + "','" + month + "'";

                SqlCommand command = new SqlCommand(sql1, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataSet myDataSet = new DataSet();

                dataAdapter.Fill(myDataSet, "top_staff");

                //使用DataSet绑定时，必须同时指明DateMember 
                this.dataGridView.DataSource = myDataSet;
                this.dataGridView.DataMember = "top_staff";

                //改变DataGridView的表头
                this.dataGridView.Columns[0].HeaderText = "员工";
                this.dataGridView.Columns[1].HeaderText = "销售额";

                //设置DataGridView的列宽度
                dataGridView.Columns[0].Width = 140;
                dataGridView.Columns[1].Width = 120;

                /*
                //自适应DataGridView的列宽度
                dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                */

                //不显示出dataGridView的最后一行空白
                dataGridView.AllowUserToAddRows = false;

                //不允许在dataGridView上直接编辑
                dataGridView.ReadOnly = true;

                //设置控件选中选中的模式  
                //单击单元格或行标题可以选中整行  
                this.dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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

        private void buttonOK_Click(object sender, EventArgs e)
        {
            year = comboBoxYear.Text;
            month = comboBoxMonth.Text;
            initDataGridView();
        }

        private void FormExecTopStaff_Load(object sender, EventArgs e)
        {
            comboBoxYear.Text = year;
            comboBoxMonth.Text = month;

            initDataGridView();
        }
    }
}
