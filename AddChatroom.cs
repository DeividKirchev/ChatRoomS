using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatRoomS
{
    public partial class AddChatroom : Form
    {
        public AddChatroom()
        {
            InitializeComponent();
        }

        private void AddChatroom_Load(object sender, EventArgs e)
        {

        }
   
        private void Enter_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.NewRoomID = Int32.Parse(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }

        }
    }
}
