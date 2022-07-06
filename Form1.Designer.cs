
namespace ChatRoomS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ChatRooms = new System.Windows.Forms.ListBox();
            this.label_id = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.curr_room_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Chat = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChatRooms
            // 
            this.ChatRooms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ChatRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.ChatRooms.FormattingEnabled = true;
            this.ChatRooms.ItemHeight = 29;
            this.ChatRooms.Location = new System.Drawing.Point(12, 87);
            this.ChatRooms.Name = "ChatRooms";
            this.ChatRooms.Size = new System.Drawing.Size(371, 497);
            this.ChatRooms.TabIndex = 0;
            this.ChatRooms.SelectedIndexChanged += new System.EventHandler(this.ChatRooms_SelectedIndexChanged);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label_id.Location = new System.Drawing.Point(12, 38);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(121, 29);
            this.label_id.TabIndex = 1;
            this.label_id.Text = "ID: #0000";
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Add.Location = new System.Drawing.Point(218, 26);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(165, 52);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add Room";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // curr_room_name
            // 
            this.curr_room_name.AutoSize = true;
            this.curr_room_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.curr_room_name.Location = new System.Drawing.Point(515, 38);
            this.curr_room_name.Name = "curr_room_name";
            this.curr_room_name.Size = new System.Drawing.Size(81, 29);
            this.curr_room_name.TabIndex = 4;
            this.curr_room_name.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(420, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Chat
            // 
            this.Chat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chat.BackColor = System.Drawing.Color.White;
            this.Chat.Cursor = System.Windows.Forms.Cursors.Default;
            this.Chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Chat.ForeColor = System.Drawing.Color.Black;
            this.Chat.Location = new System.Drawing.Point(420, 87);
            this.Chat.Multiline = true;
            this.Chat.Name = "Chat";
            this.Chat.ReadOnly = true;
            this.Chat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Chat.Size = new System.Drawing.Size(685, 444);
            this.Chat.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox1.Location = new System.Drawing.Point(420, 537);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(548, 47);
            this.textBox1.TabIndex = 7;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnSend.Location = new System.Drawing.Point(974, 537);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(131, 47);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 600);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Chat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.curr_room_name);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.ChatRooms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ChatRoomS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ChatRooms;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label curr_room_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Chat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSend;
    }
}

