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
        private int user_id;
        private int cr_id;
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
                label_id.Text = "ID - #"+dataReader["ID"].ToString();
                user_id = Int32.Parse(dataReader["ID"].ToString());
            }
            else
            {
                dataReader.Close();
                cmd.CommandText = "INSERT INTO USERS(NAME,PASSWORD,EMAIL,IP) VALUES('test','test','test','" + IP + "')";
                cmd.ExecuteNonQuery();
            
                cmd = new MySqlCommand("SELECT * FROM USERS WHERE IP LIKE '"+IP+"'", conn);
                dataReader = cmd.ExecuteReader();
                label_id.Text = "ID - #"+dataReader["ID"].ToString();
                user_id = Int32.Parse(dataReader["ID"].ToString());
            }
            dataReader.Close();
            cmd = new MySqlCommand("SELECT * FROM Chatroom WHERE user1_id = " + user_id + " or user2_id = " + user_id, conn);
            dataReader = cmd.ExecuteReader();
            while(dataReader.Read())
            {
                ChatRooms.Items.Add("#" + dataReader["user1_id"] + " and #" + dataReader["user2_id"]);
            }
            dataReader.Close();
        }
        public static int NewRoomID ;
        private void Add_Click(object sender, EventArgs e)
        {
            NewRoomID = 0;
            AddChatroom addChatroom = new AddChatroom();
            addChatroom.ShowDialog();
            if(NewRoomID!=0)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM CHATROOM WHERE USER1_ID = " + NewRoomID + " AND USER2_ID =" + user_id + " OR USER2_ID = " + NewRoomID + " AND USER1_ID =" + user_id, conn);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    if (!dataReader.Read())
                    {
                        dataReader.Close();
                        cmd = new MySqlCommand("INSERT INTO CHATROOM(USER1_ID,USER2_ID) VALUES(" + NewRoomID + "," + user_id + ")", conn);
                        cmd.ExecuteNonQuery();
                        ChatRooms.Items.Add("#" + user_id + " and #" + NewRoomID);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void setChat(int index)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM CHATROOM WHERE USER1_ID = " + index + " AND USER2_ID =" + user_id + " OR USER2_ID = " + index + " AND USER1_ID =" + user_id, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            if (!dataReader.Read())
            {
                dataReader.Close();
                return;
            }
            int croom_id = Int32.Parse(dataReader["id"].ToString());
            if (cr_id == croom_id)
            {
                dataReader.Close();
                return;
            }
            cr_id = croom_id;
            //Chat.Text = chatroom_id.ToString();
            dataReader.Close();
            cmd = new MySqlCommand("SELECT * FROM MESSAGES WHERE CR_ID = " + cr_id + " ORDER BY DATE ASC", conn);
            dataReader = cmd.ExecuteReader();
            while(dataReader.Read())
            {
                Chat.AppendText("USER " + dataReader["user_id"].ToString() + ": " + dataReader["message"].ToString() + Environment.NewLine);
            }
            dataReader.Close();
        }
        private int getUserID(string s)
        {
            int pos = s.IndexOf('#');
            string s1 = s.Substring(pos+1, 1);
            int num1 = Int32.Parse(s1);
            if (num1 != user_id) return num1;

            s.Remove(pos, 1);
            pos = s.IndexOf('#');
            s1 = s.Substring(pos+1, 1);
            num1 = Int32.Parse(s1);
            return num1;

        }
        private void ChatRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index;
            index = getUserID(ChatRooms.SelectedItem.ToString());
            //Chat.Text = index.ToString();
            setChat(index);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null) return;
            Chat.AppendText("USER " + user_id +": " + textBox1.Text + Environment.NewLine);
             //Chat.AppendText(DateTime.Now.ToString());
              MySqlCommand cmd = new MySqlCommand("INSERT INTO MESSAGES(CR_ID,USER_ID,MESSAGE,DATE) VALUES(" + cr_id + "," + user_id + ",'" + textBox1.Text + "', str_to_date('" + DateTime.Now.ToShortDateString()+ "','%d/%m/%Y %T'))", conn);
             cmd.ExecuteNonQuery();
              textBox1.Clear();
        }
    }
}
