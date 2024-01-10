using System;
using System.ComponentModel;

namespace HelloWorld
{
    class Program
    {
        // static void Main(String[] args)
        // {
        //     int[] nums = new int[5]{1,3,2,9,4};

        //     insertSort(nums);

        //     for (int i = 0; i < nums.Length; i++)
        //     {
        //         Console.WriteLine(nums[i]);
        //     }
        // }

        static Array bubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }

        static Array insertSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            return arr;
        }
    }


    //Buoi 2
    class Test
    {
        enum Status
        {
            [Description("User hoat dong binh thuong")]
            ACTIVE,
            [Description("User bi xoa mem")]
            INACTIVE,
            [Description("User bi xoa cung")]
            PENDING
        }

        interface IAnimal {
            void makeNoise();
        }

        interface IRecycleBin {
            void test();
        }

        class Wibu : IAnimal, IRecycleBin {
            public void makeNoise() {
                Console.WriteLine("helo mina !");
            }

            public void test() {
                Console.WriteLine("i'm recycle bin");
            }
        }

        // public static void Main(String[] args) {
        //     Wibu wibu = new Wibu();
        //     wibu.makeNoise();
        //     wibu.test();
        // }

        class Program {
            public static int devide(int num1, int num2) {
                if(num2 == 0) {
                    throw new CustomNumberIntergerException("Wibu in the core of earth");
                }
                return num1/num2;
            }
        }

        public class CustomNumberIntergerException : ApplicationException {
            public CustomNumberIntergerException(String message) : base(message) {}
        }
    }
}