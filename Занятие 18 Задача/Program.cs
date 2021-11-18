using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_18_Задача
{
    class Program
    {
        //задача : проверить корректно ли расставлены скобки
        static void Main(string[] args)
        {
            string str = "({}{[]{}()}{}";
            Stack<char> stk = new Stack<char>();
            bool trouble = false;
            Console.WriteLine(str);
            foreach (var item in str)
            {
                switch (item)
                {
                    case '(':
                        stk.Push(')');
                        break;

                    case '[':
                        stk.Push(']');
                        break;

                    case '{':
                        stk.Push('}');
                        break;

                    case ')':
                        trouble = PopStack(stk, item);
                        break;

                    case ']':
                        trouble = PopStack(stk, item);
                        break;
                    case '}':
                        trouble = PopStack(stk, item);
                        break;
                }
            }
            if (trouble || stk.Count > 0)
            {
                Console.WriteLine("Скобки не корректны");
            }
            else
            {
                Console.WriteLine("Скобки корректны");
            }
            Console.ReadKey();

        }
        static bool PopStack(Stack<char> stk, char item)
        {
            if (stk.Count > 0 && item == stk.Peek())
            {
                stk.Pop();
                return false;
            }
            else
            {
                return true;

            }
        }
    }
}