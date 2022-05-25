using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public class Todo
    {
        string title;
        int id = 1;
        bool isDone = false;
        public static int newId = 1;
        public Todo()
        {
            this.id = newId;
            newId++;
            this.title = "1";
        }
        public Todo(string title)
        {
            this.id = newId;
            newId++;
            this.title = title;            
        }
        public string Title { get { return this.title; } set { this.title = value; } }
        public bool IsDone { get { return this.isDone; } set { this.isDone = value; } }

        public int Id { get { return this.id; } set { this.id = value; } }

        public override string ToString()
        {
            if (this.isDone == true)
            {
                return $"[x] {this.id} {this.Title} ";
            }
            else
            {
                return $"{this.id} {this.Title} ";
            }            
        }
    }
}
