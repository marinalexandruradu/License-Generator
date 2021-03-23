using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LicenseGenerator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        public static string AddCheckDigit(string number)
        {
            int Sum = 0;
            for (int i = number.Length - 1, Multiplier = 2; i >= 0; i--)
            {
                Sum += (int)char.GetNumericValue(number[i]) * Multiplier;

                if (++Multiplier == 8) Multiplier = 2;
            }
            string Validator = (11 - (Sum % 11)).ToString();

            if (Validator == "11") Validator = "0";
            else if (Validator == "10") Validator = "X";

            return number + Validator;
        }

        public static string GenerateRandom() {
            Random rnd = new Random();
            int digitcode = rnd.Next(100000000, 999999999);

            string myString = digitcode.ToString();
            string test2 = AddCheckDigit(myString);
            return test2;
        }

        public static string GenerateUnix() {
            Random rnd = new Random();
            int month = rnd.Next(1, 364);
            int digitcode = rnd.Next(100000000, 999999999);
            DateTime dt = new DateTime(2021, 1, 1);
            DateTime newDate = dt.AddDays(month);

            Int32 unixTimestamp = (Int32)(newDate.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            string myUnixString = unixTimestamp.ToString();
            return myUnixString;
        }

        
        static void Main()
        {

            //Random rnd = new Random();
            //int month = rnd.Next(1, 364);
            //int digitcode = rnd.Next(100000000, 999999999);
            //DateTime dt = new DateTime(2021, 1, 1);
            //DateTime newDate = dt.AddDays(month);

            //Int32 unixTimestamp = (Int32)(newDate.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;

            //Console.WriteLine(unixTimestamp);
            //string myString = digitcode.ToString();
            //string myUnixString = unixTimestamp.ToString();

            //System.DateTime dtDateTime = new DateTime(1970, 1, 1);
            //dtDateTime = newDate.AddMilliseconds(unixTimestamp).ToLocalTime();
            //int year = dtDateTime.Year;
            //if  (year = 2021) { }
            //Console.WriteLine(dtDateTime);
            //Console.WriteLine(year);

            //string test2 = AddCheckDigit(myString);

            //Console.WriteLine(test2);
            //Console.WriteLine(tessst);

            //Console.WriteLine("Serial key:" + myUnixString + "-" + myString + "-");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
