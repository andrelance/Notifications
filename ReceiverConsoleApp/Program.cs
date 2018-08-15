using StorageService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiverConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria o objeto que irá acessar o serviço de mensageria
            QueueService queueService;
            queueService = new QueueService();

            string message = queueService.GetMessage("andre");
            do
            {
                message = queueService.GetMessage("andre");
                Console.WriteLine(message);
            } while (String.IsNullOrEmpty(message));

            //Aguarda o ENTER
            Console.ReadLine();
        }
    }
}
