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
                MessageBox.Show("ע��ɹ�");
            }
            else
            {
                MessageBox.Show("ע��ʧ��");
            }
        }
        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (sdk.SignIn(IDInputBox.Text, passwordInputBox.Text))
            {
                MessageBox.Show("��¼�ɹ�");
                foreach (string friend_id in sdk.friendList)
                {
                    friendIDList.Items.Add(friend_id);
                }
                Task.Run(ReceiveMessage);
            }
            else
            {
                MessageBox.Show("��¼ʧ��");
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
                        messageList.Items.Add("���յ���" + msg.sender_id + "����Ϣ:" + msg.message);
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