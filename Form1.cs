using OnlineChat;
namespace OnlineChatWindowsClient
{
    public partial class Form1 : Form
    {
        OnlineChatClientSDK sdk = new OnlineChatClientSDK();
        public Form1()
        {
            InitializeComponent();
            sdk.Connect();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (sdk.SignUp(IDInputBox.Text, passwordInputBox.Text))
            {
                MessageBox.Show("注册成功");
            }
            else
            {
                MessageBox.Show("注册失败");
            }
        }
        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (sdk.SignIn(IDInputBox.Text, passwordInputBox.Text))
            {
                MessageBox.Show("登录成功");
                foreach (string friend_id in sdk.friendList)
                {
                    friendIDList.Items.Add(friend_id);
                }
                Task.Run(ReceiveMessage);
            }
            else
            {
                MessageBox.Show("登录失败");
            }
        }
        private void ReceiveMessage()
        {
            while (true)
            {
                OnlineChat.Message msg;
                if (sdk.messages.TryDequeue(out msg))
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        messageList.Items.Add("接收到了" + msg.sender_id + "的消息:" + msg.message);
                    });

                }
            }
        }
        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            sdk.SendMessage(sendMessageFriendIDInputBox.Text, messageInputBox.Text);
        }

        private void AddFriend_Click(object sender, EventArgs e)
        {
            sdk.AddFriend(addFriendFriendIDInputBox.Text);
            friendIDList.Items.Add(addFriendFriendIDInputBox.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}