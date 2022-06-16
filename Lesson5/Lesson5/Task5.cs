using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Lesson5
{
    internal class Task5
    {
        public static void GetTaskText()
        {
            ReadXml();
            List<Todo> todo = ReadXml();
            Todo.newId = todo.Count + 1;
            while (true)
            {
                Console.WriteLine("Хотите добавить новую задачу? 1 - да 0 - нет");
                if (Console.ReadLine() == "1")
                {
                    Console.WriteLine("Введите текст задачи");
                    todo.Add(new Todo(Console.ReadLine()));
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    break;
                }
            }
            printTasks(todo);
            while (true)
            {
                Console.WriteLine("Хотите отметит задачу как выполненную?" +
                " 1 - да, 0 - нет");

                if (int.Parse(Console.ReadLine()) == 1)
                {
                    SetDone(todo);
                    Console.Clear();
                    printTasks(todo);
                }
                else
                {
                    Console.Clear();
                    break;
                }                
            }            
            WriteXml(todo);                        
        }

        static void WriteXml(List<Todo> todo)
        {
            StringWriter stringWriter = new StringWriter();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Todo>));                        
            serializer.Serialize(stringWriter, todo);
            string xml = stringWriter.ToString();                
            Directory.CreateDirectory(@"C:\Под урок 5");
            File.WriteAllText(@"C:\Под урок 5\ToDoList.xml", xml);
        }

        public static List<Todo> ReadXml()
        {
            if (File.Exists(@"C:\Под урок 5\ToDoList.xml") == false)
            {
                return new List<Todo>();
            }
            string xmlText = File.ReadAllText(@"C:\Под урок 5\ToDoList.xml");            
            StringReader stringReader = new StringReader(xmlText);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Todo>));
            List<Todo> todoList = (List<Todo>)serializer.Deserialize(stringReader);
            return todoList;
        }
        public static void SetDone(List<Todo> todo)
        {
            Console.WriteLine("Для отметки выполненным введите номер задачи ");
            int taskNumber = int.Parse(Console.ReadLine());
            foreach (var a in todo)
            {
                if (taskNumber == a.Id)
                {
                    a.IsDone = true;
                }
            }            
        }
        public static void printTasks(List<Todo> todo)
        {
            foreach (Todo a in todo)
            {
                Console.WriteLine(a);
            }
        }
    }
}
