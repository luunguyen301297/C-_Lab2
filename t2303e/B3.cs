using System;
using System.ComponentModel;
using System.Drawing;

namespace B3
{

    class Student
    {
        // private int _id;

        // public int Id
        // {
        //     get => _id;
        //     set
        //     {
        //         if (value > 0 && value < 10) _id = value;
        //         else Console.WriteLine("Unknown");
        //     }
        // }

        // public int Age {get; set;}

        // public string? FullName{get; set;}


        // public static void Main(string[] args)
        // {
        //     Student s = new Student();
        //     s.Id = 5;
        //     Console.WriteLine(s.Id);
        // }
    }

    class StudentIndexer
    {
        private string[] names;
        private int size;

        public StudentIndexer(int size)
        {
            this.size = size;
            names = new string[size];

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = "N/A";
            }
        }

        // get element of names
        public string this[int index]
        {
            get
            {
                return (index >= 0 && index <= names.Length) ? names[index] : "";
            }
            set
            {
                if (index >= 0 && index <= names.Length)
                {
                    names[index] = value;
                }
            }
        }

        // public static void Main(string[] args)
        // {
        //     StudentIndexer indexer = new StudentIndexer(10);
        //     for (int i = 0; i < indexer.names.Length; i++)
        //     {
        //         indexer[i] = randomStr(10);
        //     }
        //     for (int i = 0; i < indexer.names.Length; i++)
        //     {
        //         Console.WriteLine(indexer[i]);
        //     }
        // }

        private static Random random = new Random();
        public static string randomStr(int length) {
            const string chars = "ABCDEFGHIKLMNOPQRSTUVWXYZ123456789";
            return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }

}