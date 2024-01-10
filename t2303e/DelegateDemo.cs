using System;
using System.ComponentModel;
using System.Drawing;

namespace Delegate
{

    class Program
    {
        delegate int DelegateDemo(string s);

        static int convert(String strValue) {
            return Int32.Parse(strValue);
        }

        static int show(string value) {
            Console.WriteLine(value);
            return 0;
        }


            // static void Main(string[] args)
            // {
            //     DelegateDemo delegateDemo = new DelegateDemo(convert);
            //     DelegateDemo delegateShow = new DelegateDemo(show);
            //     DelegateDemo multiDelegate = delegateDemo + delegateShow;
            //     string intString = "20";
            //     int num = multiDelegate(intString);
            //     Console.WriteLine(num);
            //     Type type = num.GetType();
            //     Console.WriteLine(type);
            // }
    }

    class Program2 {
        delegate int Calculator(int a, int b);

            // public static void Main(string[] args)
            // {
            //     Calculator sum = (int a, int b) => a + b;
            //     Calculator multiple = (int a, int b) => a * b;
            //     Calculator divide = (int a, int b) => a / b;
            // }
    }

}