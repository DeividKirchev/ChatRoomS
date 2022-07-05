using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
namespace ChatRoomS
{
    public partial class Form1 : Form
    {
        public string connString = "server=192.168.0.109;port=3306;user id=root;password=asdasdasd123AS;persistsecurityinfo=True;database=chatroomdb";
        MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            try
            {
                conn = new MySqlConnection(connString);
                conn.Open();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            string hostName = Dns.GetHostName();
            string IP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM USERS WHERE IP LIKE '"+IP+"'",conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            if(dataReader.Read())
            {
                label_id.Text = dataReader["ID"].ToString();
            }
            else
            {
                dataReader.Close();
                cmd.CommandText = "INSERT INTO USERS(NAME,PASSWORD,EMAIL,IP) VALUES('test','test','test','" + IP + "')";
                cmd.ExecuteNonQuery();
            
                cmd = new MySqlCommand("SELECT * FROM USERS WHERE IP LIKE '"+IP+"'", conn);
                dataReader = cmd.ExecuteReader();
                label_id.Text = dataReader["ID"].ToString();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {

        }
    }
}
