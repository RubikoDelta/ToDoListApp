// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
namespace TodoApp
{

    public class Task
    {
        public int idTask = 0;
        public string descriptionTask = string.Empty;

        public int status = 0;

    }
    public class Program()
    {


        public static void Main(string[] args)
        {

            Task taskItem = new Task();


            bool exitApp = false;
            while (exitApp == false)
            {
                Console.WriteLine("Escriba lo que desee hacer");
                string orden = Console.ReadLine();
                switch (orden)
                {
                    case "Add":

                        string newTask = string.Empty;
                        bool taskEmpty = false;
                        while (!taskEmpty)
                        {
                            Console.WriteLine("Escriba la tarea que desea agregar");
                            newTask = Console.ReadLine() ?? string.Empty;
                            taskEmpty = string.IsNullOrEmpty(newTask) ? false : true;
                        }

                        //Agregando un comentario random
                        AddTask(newTask);
                        break;
                    case "Exit":
                        exitApp = true;
                        break;
                    default:
                        Console.WriteLine("Comando invalido. Intentar nuevamente");
                        break;
                }

            }
        }

        static void AddTask(string? newTask)
        {

            //Aqui se debera leer un fichero del tipo json llamado "tasks.json"
            //Sino existe, entonces se debe crear


        }

    }
}








