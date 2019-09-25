using System;
using System.Net.Sockets;
using System.Text;

namespace TcpClientApp
{
    class Program
    {
        private const int port = 8888;
        private const string server = "127.0.0.1";

        static void Main(string[] args)
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(server, port);
                NetworkStream stream = client.GetStream();
                while (true)
                {
                    //Отправка
                    string answer = Console.ReadLine();
                    byte[] data1 = Encoding.UTF8.GetBytes(answer);
                    stream.Write(data1, 0, answer.Length);
                    Console.WriteLine("Отправлено сообщение: {0}", answer);
                    //Получение
                    StringBuilder response = new StringBuilder();
                    byte[] data = new byte[256];
                    int bytes = stream.Read(data, 0, data.Length);
                    response.Append(Encoding.UTF8.GetString(data, 0, bytes));
                    Console.WriteLine(response.ToString());
                    Console.WriteLine("Получено сообщение: {0}", response);
                }
            
            }
           
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }

            Console.WriteLine("Запрос завершен...");
            Console.Read();
        }
    }
}