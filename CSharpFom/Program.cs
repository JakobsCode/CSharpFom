using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using class1;

namespace CSharpFom
{
    class Program
    {
        public static void Main()
        {
            myStack st = new myStack();
            bool stop = false;
            while (!stop)
            {
                string methode = Console.ReadLine().ToLower();
                switch (methode)
                {
                    case "init": Console.WriteLine("Programm gestartet"); break;
                    case "end": stop = true; break;
                    case "push": methode = Console.ReadLine().ToLower(); st.push(methode); break;
                    case "pop": st.pop(); break;
                    default: Console.WriteLine("Error"); break;

                }
            }
        }
    }
}