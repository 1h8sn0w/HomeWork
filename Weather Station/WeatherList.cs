using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Station
{
    class WeatherList
    {
        string[] stack;
        int head = -1;
        public WeatherList(int size)
        {
            stack = new string[size];
        }
        public void Push(string element)//добавление
        {
            head++;
            stack[head] = element;            
        }
        public string Pop()//извлечение
        {
            //if (!IsEmpty())
            //{


            return (stack[head]);
            //head--;
            //}
            //else 
        }
        public int Size()//инициализация
        {
            return stack.Length;
        }
        public string List()//вывод
        {
            head--;
            return (stack[head]);
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

