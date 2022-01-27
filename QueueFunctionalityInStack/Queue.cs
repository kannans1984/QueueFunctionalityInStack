using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueFunctionalityInStack
{
    public class Queue
    {

        Stack<int> stack1 = new Stack<int>();
        Stack<int> stack2 = new Stack<int>();


        public void Enqueue(int itemToEnqueue)
        {
            if(stack1.Any())
            {
                while (stack1.Count != 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }
            //Console.WriteLine($"Enqueue :  {itemToEnqueue}");
            stack1.Push(itemToEnqueue);

            if(stack2.Any())
            {
                while (stack2.Count != 0)
                {
                    stack1.Push(stack2.Pop());
                }
            }
        }

        public void DeQueue()
        {
            //Console.WriteLine($"Dequeue :  {stack1.Peek()}");
            stack1.Pop();
        }

        public void Print()
        {
            Console.WriteLine("Items in stack");
            foreach(var item in stack1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
