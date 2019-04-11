using System;

namespace Weather_Station
{
    internal class WeatherList
    {
        private readonly string[] stack;
        private int head = -1;

        public WeatherList()
        {
            stack = new string[10];
        }

        public WeatherList(int size)
        {
            stack = new string[size];
        }

        public void Push(string element) //добавление
        {
            head++;
            stack[head] = element;
        }

        public string Peek()
        {
            return stack[head];
        }

        public string Pop() //извлечение
        {
            //if (!IsEmpty())
            //{


            return stack[head];
            //head--;
            //}
            //else 
        }

        public int Size() //инициализация
        {
            return stack.Length;
        }

        public string List() //вывод
        {
            head--;
            return stack[head];
        }

        public bool IsFull()
        {
            return head == stack.Length - 1;
        }

        public bool IsEmpty()
        {
            return head == -1;
        }

        public void Print()
        {
            Console.WriteLine("*************************");
            foreach (var item in stack)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("*************************");
        }
    }
}