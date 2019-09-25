using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TcpListenerApp
{
    class Program
    {
        const int port = 8888; // порт для прослушивания подключений
        static void Main(string[] args)
        {
            TcpListener server = null;
            try
            {
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");
                server = new TcpListener(localAddr, port);
                
                server.Start();
                Console.WriteLine("Ожидание подключений... ");

                // получаем входящее подключение
                TcpClient client = server.AcceptTcpClient();
                Console.WriteLine("Подключен клиент. Выполнение запроса...");
                // запуск слушателя
                while (true)
                {
                    // получаем сетевой поток для чтения и записи
                    NetworkStream stream = client.GetStream();
                    //Получение
                    StringBuilder get = new StringBuilder();
                    byte[] data1 = new byte[256];
                    int bytes = stream.Read(data1, 0, data1.Length);
                    get.Append(Encoding.UTF8.GetString(data1, 0, bytes));
                    Console.WriteLine(get.ToString());
                    Console.WriteLine("Получено сообщение: {0}", get);
                    // сообщение для отправки клиенту
                  
                    string response = " ";
                    string path = "D:\\Chlen.txt";
                    string line;
                    string[] delimiterString = { "<<", "...", " ",", " };
                    StreamReader sr = new StreamReader(path, System.Text.Encoding.Default);
                    line = sr.ReadToEnd();
                    string[] words = line.Split(delimiterString, System.StringSplitOptions.RemoveEmptyEntries);
                    foreach(var word in words)
                    {
                       // Console.WriteLine(word);
                        if (word.Contains(get.ToString()))
                        {
                            response = "true";
                        }
                       /* else
                        {
                            response = " false";
                        }*/
                    }
                
                    // преобразуем сообщение в массив байто
                    byte[] data = Encoding.UTF8.GetBytes(response);
                    // отправка сообщения
                    stream.Write(data, 0, data.Length);
                    Console.WriteLine("Отправлено сообщение: {0}", response);
                   
                }
          
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

                if (server != null)
                    server.Stop();
            }
        }
    }
}