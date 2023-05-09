using FinalExamQ1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamQ1
{
    public class MyStack
    {

        List<int> list = new List<int>();

            public void Push(int n)
            { 
                list.Add(n); 
            }

            public int Pop()
            {
              int top = 0;
              int index = list.Count - 1;

            if (index == -1)
            {
                Console.WriteLine("ERROR: Empty Stack!");
            }
            else
            {
                 top = list[index];

                list.RemoveAt(index);
            }

                return top;
            }
        
            public int Peek()
            {
            int top = 0;
            int index = list.Count - 1;
            if (index == -1)
                {
                Console.WriteLine("ERROR: Empty Stack!");
                }

            else
            {
                top = list[index];
            }

            return top;
        }
    }
}
internal class Program
    {
        static void Main(string[] args)
        {
            MyStack myStack = new MyStack();

            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);   
            myStack.Push(4);
        
            Console.WriteLine(myStack.Peek());
            
            Console.WriteLine(myStack.Pop());
        Console.WriteLine(myStack.Pop());

        }
    }

