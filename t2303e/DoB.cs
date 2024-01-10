using System;
using System.ComponentModel;

namespace DoB {

    class DoB {

        // public static void Main(String[] args) {
        //     int day;
        //     int month;
        //     int year;

        //     Console.WriteLine("Enter DoB :");
        //     day = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine("Enter MoB :");
        //     month = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine("Enter YoB :");
        //     year = Convert.ToInt32(Console.ReadLine());

        //     if (validate(day, month, year)) {
        //         String str = day.ToString() + month.ToString() + year.ToString();
        //         int total = sumOfDigitsOfNumber(str);
        //         while (total > 11) {
        //             total = sumOfDigitsOfNumber(total.ToString());
        //         }
        //         Console.WriteLine("Result: " + total);
        //     } else {
        //         Console.WriteLine("Invalid date of birth");
        //     }
        // }

        public static int sumOfDigitsOfNumber(string number) {
            int total = 0;
            for (int i = 0; i < number.Length; i++) {
                total += int.Parse(number[i].ToString());
            }
            return total;
        }

        public static bool validate(int day, int month, int year) {
            if (day < 1 || day > 31) return false;
            if (month < 1 || month > 12) return false;
            if (year < DateTime.Now.Year - 150 || year > DateTime.Now.Year) return false;

            switch (month) {
                case 4:
                case 6:
                case 9:
                case 11:
                    if (day > 30) return false;
                    break;
            }

            if (month == 2) {
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) {
                    if (day > 29) return false;
                } else {
                    if (day > 28) return false;
                }
            }
            
            return true;
        }

    }

}