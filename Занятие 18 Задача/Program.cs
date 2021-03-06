using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_18_Задача
{
    class Program
    {
        //задача: проверить корректно ли расставлены скобки в строке
        static void Main(string[] args)
        {
            string str = "({}(){}{})"; // данная строка
            Stack<char> stk = new Stack<char>();
            bool trouble = false;
            Console.WriteLine(str);
            foreach (var item in str) // перебираем символы скобок в цикле
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
                Console.WriteLine("Скобки расставлены не корректно");
            }
            else
            {
                Console.WriteLine("Скобки расставлены корректно");
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