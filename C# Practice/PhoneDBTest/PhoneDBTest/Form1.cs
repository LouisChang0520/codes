using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PhoneDBTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string workPath = "";
        private string ConnOne;
        private int IN;

        private void MainForm_Load(object sender, EventArgs e)
        {
            workPath = Directory.GetCurrentDirectory();
            ConnOne = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + workPath + "\\dataBase\\phoneTest.accdb";
            OleDbConnection ConnTwo = new OleDbConnection(ConnOne);
            if (ConnTwo.State == ConnectionState.Closed)
                ConnTwo.Open();
            string SelectGetPhoneNum = "SELECT * FROM list";
            try
            {
                OleDbCommand CmdGetPhoneNum = new OleDbCommand(SelectGetPhoneNum, ConnTwo);
                OleDbDataReader GetPhoneNum = CmdGetPhoneNum.ExecuteReader();
                if (GetPhoneNum.HasRows)
                {
                    SLTcomboBox.Items.Clear();
                    while (GetPhoneNum.Read())
                    {
                        string mName = GetPhoneNum["NAME"].ToString();
                        SLTcomboBox.Items.Add(mName);
                    }
                    SLTcomboBox.SelectedIndex = 0;
                    IN = SLTcomboBox.SelectedIndex;
                }
                GetPhoneNum.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong!!!You idiot!!", "錯啦!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SHButton_Click(object sender, EventArgs e)
        {
            IN = SLTcomboBox.SelectedIndex;
            OleDbConnection ConnTwo = new OleDbConnection(ConnOne);
            if (ConnTwo.State == ConnectionState.Closed)
                ConnTwo.Open();
            string SelectGetData = "SELECT * FROM list WHERE NAME ='" + SLTcomboBox.Text + "'";
            try
            {
                OleDbCommand CmdGetData = new OleDbCommand(SelectGetData, ConnTwo);
                OleDbDataReader GetData = CmdGetData.ExecuteReader();
                if (GetData.HasRows)
                {
                    if (GetData.Read())
                    {
                        NumBox.Text = GetData["S_NO"].ToString();
                        NameBox.Text = GetData["NAME"].ToString();
                        SexBox.Text = GetData["SEX"].ToString();
                        PhoneBox.Text = GetData["TEL"].ToString();
                        DateTime BTH = Convert.ToDateTime(GetData["BIRTHDAY"]);
                        BirthBox.Text = BTH.ToString("yyyy/MM/dd");
                        AdsBox.Text = GetData["ADDRESS"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong!!!You idiot!!", "錯啦!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            OleDbConnection ConnTwo = new OleDbConnection(ConnOne);
            if (ConnTwo.State == ConnectionState.Closed)
                ConnTwo.Open();
            string SelectGetPhoneNum = "SELECT * FROM list";
            try
            {
                OleDbCommand CmdGetPhoneNum = new OleDbCommand(SelectGetPhoneNum, ConnTwo);
                OleDbDataReader GetPhoneNum = CmdGetPhoneNum.ExecuteReader();
                if (GetPhoneNum.HasRows)
                {
                    SLTcomboBox.Items.Clear();
                    while (GetPhoneNum.Read())
                    {
                        string mName = GetPhoneNum["NAME"].ToString();
                        SLTcomboBox.Items.Add(mName);
                    }
                    SLTcomboBox.SelectedIndex = 0;
                    IN = SLTcomboBox.SelectedIndex;
                }
                GetPhoneNum.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("異常", "就說錯啦", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            OleDbConnection ConnTwo = new OleDbConnection(ConnOne);
            if (ConnTwo.State == ConnectionState.Closed)
                ConnTwo.Open();
            string EditData = "UPDATE list SET [S_NO] = '" + NumBox.Text + "', [NAME] = '" + NameBox.Text + "', [SEX] = '" + SexBox.Text + "', [TEL] = '" + PhoneBox.Text + "', [BIRTHDAY] = '" + BirthBox.Text + "', [ADDRESS] = '" + AdsBox.Text + "' " + "WHERE NAME = '" + SLTcomboBox.Text + "'";
            try
            {
                OleDbCommand CmdData = new OleDbCommand(EditData, ConnTwo);
                OleDbDataReader Data = CmdData.ExecuteReader();
                Data.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("錯啦!!笨蛋!!");
            }
            string SelectGetPhoneNum = "SELECT * FROM list";
            try
            {
                OleDbCommand CmdGetPhoneNum = new OleDbCommand(SelectGetPhoneNum, ConnTwo);
                OleDbDataReader GetPhoneNum = CmdGetPhoneNum.ExecuteReader();
                if (GetPhoneNum.HasRows)
                {
                    SLTcomboBox.Items.Clear();
                    while (GetPhoneNum.Read())
                    {
                        string mName = GetPhoneNum["NAME"].ToString();
                        SLTcomboBox.Items.Add(mName);
                    }
                    SLTcomboBox.SelectedIndex = 0;
                    IN = SLTcomboBox.SelectedIndex;
                }
                GetPhoneNum.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("錯啦", "就說錯啦", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            OleDbConnection ConnTwo = new OleDbConnection(ConnOne);
            if (ConnTwo.State == ConnectionState.Closed)
                ConnTwo.Open();
            string DeleteData = "DELETE FROM list WHERE NAME = '" + SLTcomboBox.Text + "'";
            try
            {
                OleDbCommand CmdData = new OleDbCommand(DeleteData, ConnTwo);
                OleDbDataReader Data = CmdData.ExecuteReader();
                Data.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("不行刪!!");
            }
            string SelectGetPhoneNum = "SELECT * FROM list";
            try
            {
                OleDbCommand CmdGetPhoneNum = new OleDbCommand(SelectGetPhoneNum, ConnTwo);
                OleDbDataReader GetPhoneNum = CmdGetPhoneNum.ExecuteReader();
                if (GetPhoneNum.HasRows)
                {
                    SLTcomboBox.Items.Clear();
                    while (GetPhoneNum.Read())
                    {
                        string mName = GetPhoneNum["NAME"].ToString();
                        SLTcomboBox.Items.Add(mName);
                    }
                    SLTcomboBox.SelectedIndex = 0;
                    IN = SLTcomboBox.SelectedIndex;
                }
                GetPhoneNum.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("取得異常", "就說異常!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}