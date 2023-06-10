using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ChatServerSDK
{
    class ChatServerSocketSDK
    {
        TcpClient server = new TcpClient();
        byte[] buffer = new byte[1024];
        public string bufferString = "";
        private string? SplitFirstJson()
        {
            int cnt = 0;
            for (int i = 0; i < bufferString.Length; i++)
            {
                if (bufferString[i] == '{')
                {
                    cnt++;
                }
                else if (bufferString[i] == '}')
                {
                    if (cnt > 0)
                    {
                        cnt--;
                        if (cnt == 0)
                        {
                            string res = bufferString.Substring(0, i + 1);
                            bufferString = bufferString.Substring(i + 1);
                            return res;
                        }
                    }
                    else
                    {
                        throw new Exception("algorithm error");
                    }
                }
            }
            return null;
        }
        //默认服务ip120.53.14.170
        public bool Connect(string ip, int port)
        {

            try
            {
                server.Connect(ip, port);
                Task.Run(ListenAndPrint);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }


        private string ReceiveJsonString(TcpClient client)
        {
            string? json = null;
            while (json == null)
            {
                json = SplitFirstJson();
                if (json != null)
                {
                    return json;
                }
                NetworkStream clientStream = client.GetStream();
                int byteReceived;
                try
                {
                    byteReceived = clientStream.Read(buffer, 0, buffer.Length);
                }
                catch (Exception ex)
                {
                    return null;
                }
                bufferString += Encoding.UTF8.GetString(buffer, 0, byteReceived);
            }
            return json;
        }
        public void ListenAndPrint()
        {
            byte[] buffer = new byte[1024];
            while (true)
            {
                Console.WriteLine(ReceiveJsonString(server));
            }
        }
        public void SignUp(string id, string password, string name, string phone_number, string email)
        {
            string str = JsonSerializer.Serialize(
                new { methodName = "SignUp", methodParams = new[] { id, password, name, phone_number, email } }
            );
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            server.GetStream().Write(bytes, 0, bytes.Length);
        }

        public void SignIn(string id, string password)
        {
            string str = JsonSerializer.Serialize(
                new { methodName = "SignIn", methodParams = new[] { id, password } }
            );
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            server.GetStream().Write(bytes, 0, bytes.Length);
        }
        public void AddFriend(string id, string friend_id)
        {
            string str = JsonSerializer.Serialize(
                new { methodName = "AddFriend", methodParams = new[] { id, friend_id } }
            );
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            server.GetStream().Write(bytes, 0, bytes.Length);
        }
        public void GetFriendList(string id)
        {
            string str = JsonSerializer.Serialize(
                new { methodName = "GetFriendList", methodParams = new[] { id } }
            );
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            server.GetStream().Write(bytes, 0, bytes.Length);
        }
        public void SendMessage(string id, string friend_id, string message)
        {
            string str = JsonSerializer.Serialize(
                new { methodName = "SendMessage", methodParams = new[] { id, friend_id, message } }
            );
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            server.GetStream().Write(bytes, 0, bytes.Length);
        }
        public void AcceptAddFriendRequest(string id, string friend_id)
        {
            //

        }
        public void GetOfflineMessage(string id)
        {
            //
        }
    }
}
