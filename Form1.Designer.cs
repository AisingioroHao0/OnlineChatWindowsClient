namespace OnlineChatWindowsClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SignInButton = new Button();
            IDInputBox = new TextBox();
            passwordInputBox = new TextBox();
            消息队列 = new ListBox();
            SignUpButton = new Button();
            messageInputBox = new TextBox();
            SendMessageButton = new Button();
            sendMessageFriendIDInputBox = new TextBox();
            addFriendFriendIDInputBox = new TextBox();
            AddFriend = new Button();
            friendIDList = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // SignInButton
            // 
            SignInButton.Location = new Point(299, 45);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(94, 29);
            SignInButton.TabIndex = 1;
            SignInButton.Text = "登录";
            SignInButton.UseVisualStyleBackColor = true;
            SignInButton.Click += SignInButton_Click;
            // 
            // IDInputBox
            // 
            IDInputBox.Location = new Point(156, 12);
            IDInputBox.Name = "IDInputBox";
            IDInputBox.Size = new Size(125, 27);
            IDInputBox.TabIndex = 4;
            // 
            // passwordInputBox
            // 
            passwordInputBox.Location = new Point(156, 44);
            passwordInputBox.Name = "passwordInputBox";
            passwordInputBox.Size = new Size(125, 27);
            passwordInputBox.TabIndex = 5;
            // 
            // 消息队列
            // 
            消息队列.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            消息队列.FormattingEnabled = true;
            消息队列.ItemHeight = 27;
            消息队列.Location = new Point(12, 80);
            消息队列.Name = "消息队列";
            消息队列.Size = new Size(585, 517);
            消息队列.TabIndex = 8;
            // 
            // SignUpButton
            // 
            SignUpButton.Location = new Point(299, 10);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(94, 29);
            SignUpButton.TabIndex = 9;
            SignUpButton.Text = "注册";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // messageInputBox
            // 
            messageInputBox.Location = new Point(12, 731);
            messageInputBox.Multiline = true;
            messageInputBox.Name = "messageInputBox";
            messageInputBox.Size = new Size(665, 86);
            messageInputBox.TabIndex = 4;
            // 
            // SendMessageButton
            // 
            SendMessageButton.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            SendMessageButton.Location = new Point(700, 788);
            SendMessageButton.Name = "SendMessageButton";
            SendMessageButton.Size = new Size(94, 29);
            SendMessageButton.TabIndex = 12;
            SendMessageButton.Text = "一键BB";
            SendMessageButton.UseVisualStyleBackColor = true;
            SendMessageButton.Click += SendMessageButton_Click;
            // 
            // sendMessageFriendIDInputBox
            // 
            sendMessageFriendIDInputBox.Location = new Point(217, 698);
            sendMessageFriendIDInputBox.Name = "sendMessageFriendIDInputBox";
            sendMessageFriendIDInputBox.Size = new Size(125, 27);
            sendMessageFriendIDInputBox.TabIndex = 13;
            // 
            // addFriendFriendIDInputBox
            // 
            addFriendFriendIDInputBox.Location = new Point(156, 637);
            addFriendFriendIDInputBox.Name = "addFriendFriendIDInputBox";
            addFriendFriendIDInputBox.Size = new Size(207, 27);
            addFriendFriendIDInputBox.TabIndex = 14;
            // 
            // AddFriend
            // 
            AddFriend.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            AddFriend.Location = new Point(388, 619);
            AddFriend.Name = "AddFriend";
            AddFriend.Size = new Size(209, 45);
            AddFriend.TabIndex = 15;
            AddFriend.Text = "  快速添加好友！";
            AddFriend.UseVisualStyleBackColor = true;
            AddFriend.Click += AddFriend_Click;
            // 
            // friendIDList
            // 
            friendIDList.FormattingEnabled = true;
            friendIDList.ItemHeight = 20;
            friendIDList.Location = new Point(638, 80);
            friendIDList.Name = "friendIDList";
            friendIDList.Size = new Size(138, 504);
            friendIDList.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 16;
            label1.Text = "请输入用户名啦";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 45);
            label2.Name = "label2";
            label2.Size = new Size(95, 24);
            label2.TabIndex = 17;
            label2.Text = "请输入密码";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(638, 31);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 18;
            label3.Text = "在线的人数";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 639);
            label4.Name = "label4";
            label4.Size = new Size(137, 25);
            label4.TabIndex = 19;
            label4.Text = "请输入好友id：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(0, 696);
            label5.Name = "label5";
            label5.Size = new Size(211, 27);
            label5.TabIndex = 20;
            label5.Text = "想给谁发？（输入id）";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 829);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddFriend);
            Controls.Add(addFriendFriendIDInputBox);
            Controls.Add(sendMessageFriendIDInputBox);
            Controls.Add(SendMessageButton);
            Controls.Add(SignUpButton);
            Controls.Add(friendIDList);
            Controls.Add(消息队列);
            Controls.Add(passwordInputBox);
            Controls.Add(messageInputBox);
            Controls.Add(IDInputBox);
            Controls.Add(SignInButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SignInButton;
        private TextBox IDInputBox;
        private TextBox passwordInputBox;
        private ListBox 消息队列;
        private Button SignUpButton;
        private TextBox messageInputBox;
        private Button SendMessageButton;
        private TextBox sendMessageFriendIDInputBox;
        private TextBox addFriendFriendIDInputBox;
        private Button AddFriend;
        private ListBox friendIDList;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}