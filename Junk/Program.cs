using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Junk
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            // my change again and again

            MyTestClass.CallMe();
        }
    }


    public class MyTestClass
    {
        static List<int> MyList = new List<int>();

        static void FillValues()
        {
            MyList.Add(1);
            MyList.Add(2);
            MyList.Add(3);
            MyList.Add(4);
            MyList.Add(5);
            MyList.Add(6);

        }

        public static void CallMe()
        {
            FillValues();
            foreach (int i in MyList)
                Console.WriteLine(i);

            var test = FilterWithYield();
            foreach(var i in test)
                Console.WriteLine("test" + test.ToString());
            var test2 = FilterWithoutYield();

            Console.ReadLine();
			
			//Making a comment here.
        }

        static IEnumerable<int> FilterWithoutYield()
        {
            List<int> temp = new List<int>();
            foreach (int i in MyList)
            {
                
                    temp.Add(i);
            }

            return temp;
        }

        static IEnumerable<int> FilterWithYield()
        {
            Console.WriteLine("FilterWithYield called");

            foreach (int i in MyList)
            {
                
                    yield return i;
            }

            Console.WriteLine("FilterWithYield done");
        }




    }
}
