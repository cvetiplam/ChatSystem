namespace Client
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.chatPanel = new System.Windows.Forms.Panel();
            this.chatInfoWithButtons = new System.Windows.Forms.Panel();
            this.btnDelChatRoom = new System.Windows.Forms.Button();
            this.btnAddPeople = new System.Windows.Forms.Button();
            this.btnLeaveChat = new System.Windows.Forms.Button();
            this.btnListChatMembers = new System.Windows.Forms.Button();
            this.btnRemoveMemberFromChat = new System.Windows.Forms.Button();
            this.chatroomsPanel = new System.Windows.Forms.Panel();
            this.lblChatroom = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.btnCreateChatroom = new System.Windows.Forms.Button();
            this.tbChatlName = new System.Windows.Forms.TextBox();
            this.usersPanel = new System.Windows.Forms.Panel();
            this.tbChatScreen = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.loginPanel.SuspendLayout();
            this.chatPanel.SuspendLayout();
            this.chatInfoWithButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(304, 374);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(246, 27);
            this.tbName.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(366, 458);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(122, 44);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(338, 123);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(178, 122);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.pbLogo);
            this.loginPanel.Controls.Add(this.btnLogin);
            this.loginPanel.Controls.Add(this.tbName);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(854, 624);
            this.loginPanel.TabIndex = 0;
            // 
            // chatPanel
            // 
            this.chatPanel.Controls.Add(this.chatInfoWithButtons);
            this.chatPanel.Controls.Add(this.chatroomsPanel);
            this.chatPanel.Controls.Add(this.lblChatroom);
            this.chatPanel.Controls.Add(this.lblUsers);
            this.chatPanel.Controls.Add(this.btnCreateChatroom);
            this.chatPanel.Controls.Add(this.tbChatlName);
            this.chatPanel.Controls.Add(this.usersPanel);
            this.chatPanel.Controls.Add(this.tbChatScreen);
            this.chatPanel.Controls.Add(this.btnSend);
            this.chatPanel.Controls.Add(this.tbMessage);
            this.chatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatPanel.Location = new System.Drawing.Point(0, 0);
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.Size = new System.Drawing.Size(854, 624);
            this.chatPanel.TabIndex = 3;
            // 
            // chatInfoWithButtons
            // 
            this.chatInfoWithButtons.Controls.Add(this.btnDelChatRoom);
            this.chatInfoWithButtons.Controls.Add(this.btnAddPeople);
            this.chatInfoWithButtons.Controls.Add(this.btnLeaveChat);
            this.chatInfoWithButtons.Controls.Add(this.btnListChatMembers);
            this.chatInfoWithButtons.Controls.Add(this.btnRemoveMemberFromChat);
            this.chatInfoWithButtons.Location = new System.Drawing.Point(752, 51);
            this.chatInfoWithButtons.Name = "chatInfoWithButtons";
            this.chatInfoWithButtons.Size = new System.Drawing.Size(99, 414);
            this.chatInfoWithButtons.TabIndex = 13;
            // 
            // btnDelChatRoom
            // 
            this.btnDelChatRoom.Location = new System.Drawing.Point(1, 209);
            this.btnDelChatRoom.Name = "btnDelChatRoom";
            this.btnDelChatRoom.Size = new System.Drawing.Size(98, 36);
            this.btnDelChatRoom.TabIndex = 13;
            this.btnDelChatRoom.Text = "delete chatroom";
            this.btnDelChatRoom.UseVisualStyleBackColor = true;
            // 
            // btnAddPeople
            // 
            this.btnAddPeople.Location = new System.Drawing.Point(0, 34);
            this.btnAddPeople.Name = "btnAddPeople";
            this.btnAddPeople.Size = new System.Drawing.Size(99, 37);
            this.btnAddPeople.TabIndex = 9;
            this.btnAddPeople.Text = "add people to chatroom";
            this.btnAddPeople.UseVisualStyleBackColor = true;
            // 
            // btnLeaveChat
            // 
            this.btnLeaveChat.Location = new System.Drawing.Point(0, 77);
            this.btnLeaveChat.Name = "btnLeaveChat";
            this.btnLeaveChat.Size = new System.Drawing.Size(99, 39);
            this.btnLeaveChat.TabIndex = 10;
            this.btnLeaveChat.Text = "leave chatroom ";
            this.btnLeaveChat.UseVisualStyleBackColor = true;
            // 
            // btnListChatMembers
            // 
            this.btnListChatMembers.Location = new System.Drawing.Point(0, 270);
            this.btnListChatMembers.Name = "btnListChatMembers";
            this.btnListChatMembers.Size = new System.Drawing.Size(99, 36);
            this.btnListChatMembers.TabIndex = 11;
            this.btnListChatMembers.Text = "List chatmembers";
            this.btnListChatMembers.UseVisualStyleBackColor = true;
            // 
            // btnRemoveMemberFromChat
            // 
            this.btnRemoveMemberFromChat.Location = new System.Drawing.Point(0, 164);
            this.btnRemoveMemberFromChat.Name = "btnRemoveMemberFromChat";
            this.btnRemoveMemberFromChat.Size = new System.Drawing.Size(99, 38);
            this.btnRemoveMemberFromChat.TabIndex = 12;
            this.btnRemoveMemberFromChat.Text = "remove member from chat";
            this.btnRemoveMemberFromChat.UseVisualStyleBackColor = true;
            // 
            // chatroomsPanel
            // 
            this.chatroomsPanel.Location = new System.Drawing.Point(4, 392);
            this.chatroomsPanel.Name = "chatroomsPanel";
            this.chatroomsPanel.Size = new System.Drawing.Size(175, 220);
            this.chatroomsPanel.TabIndex = 7;
            // 
            // lblChatroom
            // 
            this.lblChatroom.AutoSize = true;
            this.lblChatroom.Location = new System.Drawing.Point(3, 377);
            this.lblChatroom.Name = "lblChatroom";
            this.lblChatroom.Size = new System.Drawing.Size(68, 13);
            this.lblChatroom.TabIndex = 2;
            this.lblChatroom.Text = "Chat Rooms:";
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Location = new System.Drawing.Point(3, 35);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(40, 13);
            this.lblUsers.TabIndex = 1;
            this.lblUsers.Text = " Users:";
            // 
            // btnCreateChatroom
            // 
            this.btnCreateChatroom.Location = new System.Drawing.Point(89, 352);
            this.btnCreateChatroom.Name = "btnCreateChatroom";
            this.btnCreateChatroom.Size = new System.Drawing.Size(70, 38);
            this.btnCreateChatroom.TabIndex = 8;
            this.btnCreateChatroom.Text = "create chatroom";
            this.btnCreateChatroom.UseVisualStyleBackColor = true;
            // 
            // tbChatlName
            // 
            this.tbChatlName.Location = new System.Drawing.Point(385, 25);
            this.tbChatlName.Name = "tbChatlName";
            this.tbChatlName.ReadOnly = true;
            this.tbChatlName.Size = new System.Drawing.Size(189, 20);
            this.tbChatlName.TabIndex = 7;
            // 
            // usersPanel
            // 
            this.usersPanel.Location = new System.Drawing.Point(0, 51);
            this.usersPanel.Name = "usersPanel";
            this.usersPanel.Size = new System.Drawing.Size(179, 275);
            this.usersPanel.TabIndex = 6;
            // 
            // tbChatScreen
            // 
            this.tbChatScreen.Location = new System.Drawing.Point(185, 51);
            this.tbChatScreen.Multiline = true;
            this.tbChatScreen.Name = "tbChatScreen";
            this.tbChatScreen.ReadOnly = true;
            this.tbChatScreen.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbChatScreen.Size = new System.Drawing.Size(561, 414);
            this.tbChatScreen.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend.Location = new System.Drawing.Point(714, 525);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(94, 45);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(213, 495);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(459, 117);
            this.tbMessage.TabIndex = 2;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 624);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.chatPanel);
            this.Name = "LoginScreen";
            this.Text = "Chat";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.chatPanel.ResumeLayout(false);
            this.chatPanel.PerformLayout();
            this.chatInfoWithButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Panel chatPanel;
        private System.Windows.Forms.Panel usersPanel;
        private System.Windows.Forms.TextBox tbChatScreen;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Label lblChatroom;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Panel chatroomsPanel;
        private System.Windows.Forms.Button btnRemoveMemberFromChat;
        private System.Windows.Forms.Button btnListChatMembers;
        private System.Windows.Forms.Button btnLeaveChat;
        private System.Windows.Forms.Button btnAddPeople;
        private System.Windows.Forms.Button btnCreateChatroom;
        private System.Windows.Forms.TextBox tbChatlName;
        private System.Windows.Forms.Panel chatInfoWithButtons;
        private System.Windows.Forms.Button btnDelChatRoom;
    }
}

