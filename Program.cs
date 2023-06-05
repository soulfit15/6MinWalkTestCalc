using System;

namespace Calc
{
    internal class SixMinWalkTest
    {
        public static void Main(string[] args)
        {
            Console.Title = "Six Minute Walk Test Calculator";
            String title = @"  ____     ___  ____             _            _    _       _ _         _____         _        _____       _      
 / ___|    |  \/  (_)           | |          | |  | |     | | |       |_   _|       | |      /  __ \     | |     
/ /___     | .  . |_ _ __  _   _| |_ ___     | |  | | __ _| | | __      | | ___  ___| |_     | /  \/ __ _| | ___ 
| ___ \    | |\/| | | '_ \| | | | __/ _ \    | |/\| |/ _` | | |/ /      | |/ _ \/ __| __|    | |    / _` | |/ __|
| \_/ |    | |  | | | | | | |_| | ||  __/    \  /\  / (_| | |   <       | |  __/\__ \ |_     | \__/\ (_| | | (__ 
\_____/    \_|  |_/_|_| |_|\__,_|\__\___|     \/  \/ \__,_|_|_|\_\      \_/\___||___/\__|     \____/\__,_|_|\___|";
            Console.WriteLine(title);
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Please specify your gender (m/f)");
            string g = Console.ReadLine();
            Console.Beep();
            Console.WriteLine("Please Enter Your Height in cm: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.Beep();
            Console.WriteLine("");
            Console.WriteLine("Please Enter Your Weight in kg: ");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.Beep();
            Console.WriteLine("");
            Console.WriteLine("Please Enter Your Age in years:          ");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("");
            if (g == "m") 
            {
                double z = 7.57 * h - 1.76 * w - 5.02 * a - 309;
                int zconv;
                zconv = Convert.ToInt32(z);
                int min = zconv - 150;
                Console.Beep();
                Console.WriteLine("===============================================================================");
                Console.WriteLine("The Average 6-Minute Distance is:                " + zconv);
                Console.WriteLine("The Minimum value of 6 Minute Walk test is:      " + min);
                Console.WriteLine("===============================================================================");
            } else if (g == "f")
            {
                double z = 2.11 * h - 2.29 * w - 5.78 * a + 667;
                int zconv;
                zconv = Convert.ToInt32(z);
                int min = zconv - 140;
                Console.Beep();
                Console.WriteLine("===============================================================================");
                Console.WriteLine("The Average 6-Minute Distance is:                " + zconv);
                Console.WriteLine("The Minimum value of 6 Minute Walk test is:      " + min);
                Console.WriteLine("===============================================================================");
            }
            Console.WriteLine("===============================================================================");
            Console.WriteLine("This Calculator was Developed by Dr./ George Michelle");
            Console.WriteLine("2023 All Rights Reserved");
            Console.WriteLine("=======================================================");
            Console.WriteLine("Press any key to Exit .....");
            Console.ReadKey();
            
            
        }
    }
}