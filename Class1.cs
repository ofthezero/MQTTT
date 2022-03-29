using System.Text;
using uPLibrary.Networking.M2Mqtt;

namespace mqttttt
{
    public class Book
    {     
        public static void SendMessageToTopic()        
        {
            Console.WriteLine($"Для отправки сообщения введите - 1 ");
            Console.WriteLine($"Для выхода из приложения введите - 2 ");
            
            bool While = true;
            while (While) { 
          
                switch (Console.ReadLine()) 
                {
                    case "1":
                        try
                        {
                            MqttClient mqttClient2;

                            Console.WriteLine($"Введите ip: ");
                            string ip = Console.ReadLine(); //ip

                            Console.WriteLine($"Введите топик: ");
                            string topic = Console.ReadLine(); //Топик

                            Console.WriteLine($"Введите сообщение: ");
                            string message = Console.ReadLine(); //Сообщение

                            mqttClient2 = new MqttClient(ip);
                            mqttClient2.Subscribe(new string[] {topic}, new byte[] { 2 });
                            mqttClient2.Connect("192");
                            mqttClient2.Publish(topic, Encoding.UTF8.GetBytes(message));

                            Console.WriteLine($"Отправленное сообщение:  { message} ");
                            Console.WriteLine($"");
                        }
                        catch 
                        { 

                        }

                        Console.WriteLine($"Для отправки сообщения введите 1 ");
                        Console.WriteLine("Для выхода из приложения введите 2 " );
                        Console.WriteLine($"");

                    break;

                        case "2":
                        While = false;
                        Environment.Exit(0);
                        break;
                }
            }
          
        }      
    } 
}
