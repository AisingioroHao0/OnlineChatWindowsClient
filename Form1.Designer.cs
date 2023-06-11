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
            messageList = new ListBox();
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
            SignInButton.Location = new Point(330, 45);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(94, 27);
            SignInButton.TabIndex = 1;
            SignInButton.Text = "登录";
            SignInButton.UseVisualStyleBackColor = true;
            SignInButton.Click += SignInButton_Click;
            // 
            // IDInputBox
            // 
            IDInputBox.Location = new Point(146, 12);
            IDInputBox.Name = "IDInputBox";
            IDInputBox.Size = new Size(125, 27);
            IDInputBox.TabIndex = 4;
            // 
            // passwordInputBox
            // 
            passwordInputBox.Location = new Point(146, 45);
            passwordInputBox.Name = "passwordInputBox";
            passwordInputBox.Size = new Size(125, 27);
            passwordInputBox.TabIndex = 5;
            // 
            // messageList
            // 
            messageList.FormattingEnabled = true;
            messageList.ItemHeight = 20;
            messageList.Location = new Point(37, 78);
            messageList.Name = "messageList";
            messageList.Size = new Size(396, 504);
            messageList.TabIndex = 8;
            // 
            // SignUpButton
            // 
            SignUpButton.Location = new Point(330, 12);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(94, 29);
            SignUpButton.TabIndex = 9;
            SignUpButton.Text = "注册";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // messageInputBox
            // 
            messageInputBox.Location = new Point(109, 790);
            messageInputBox.Name = "messageInputBox";
            messageInputBox.Size = new Size(287, 27);
            messageInputBox.TabIndex = 4;
            // 
            // SendMessageButton
            // 
            SendMessageButton.Location = new Point(495, 788);
            SendMessageButton.Name = "SendMessageButton";
            SendMessageButton.Size = new Size(94, 29);
            SendMessageButton.TabIndex = 12;
            SendMessageButton.Text = "发送消息";
            SendMessageButton.UseVisualStyleBackColor = true;
            SendMessageButton.Click += SendMessageButton_Click;
            // 
            // sendMessageFriendIDInputBox
            // 
            sendMessageFriendIDInputBox.Location = new Point(109, 757);
            sendMessageFriendIDInputBox.Name = "sendMessageFriendIDInputBox";
            sendMessageFriendIDInputBox.Size = new Size(125, 27);
            sendMessageFriendIDInputBox.TabIndex = 13;
            // 
            // addFriendFriendIDInputBox
            // 
            addFriendFriendIDInputBox.Location = new Point(109, 602);
            addFriendFriendIDInputBox.Name = "addFriendFriendIDInputBox";
            addFriendFriendIDInputBox.Size = new Size(125, 27);
            addFriendFriendIDInputBox.TabIndex = 14;
            // 
            // AddFriend
            // 
            AddFriend.Location = new Point(240, 600);
            AddFriend.Name = "AddFriend";
            AddFriend.Size = new Size(94, 29);
            AddFriend.TabIndex = 15;
            AddFriend.Text = "  添加好友";
            AddFriend.UseVisualStyleBackColor = true;
            AddFriend.Click += AddFriend_Click;
            // 
            // friendIDList
            // 
            friendIDList.FormattingEnabled = true;
            friendIDList.ItemHeight = 20;
            friendIDList.Location = new Point(451, 45);
            friendIDList.Name = "friendIDList";
            friendIDList.Size = new Size(138, 504);
            friendIDList.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 15);
            label1.Name = "label1";
            label1.Size = new Size(23, 20);
            label1.TabIndex = 16;
            label1.Text = "id";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 45);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 17;
            label2.Text = "密码";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 607);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 18;
            label3.Text = "添加好友id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 757);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 19;
            label4.Text = "接受方id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 790);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 20;
            label5.Text = "消息";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 829);
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
            Controls.Add(messageList);
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
        private ListBox messageList;
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