using System;


namespace COMP123_Lesson02
{
    class Program
    {

        static void Main()
        {
            int strength = 50;
            int stamina = 10;
            int speed = 5;
            int toughness = 12;
            int intelligence = 2;

            Console.WriteLine("Strength in main: {0}", strength);


            increaseAbility(strength);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }


        // method to increase an ability by 2;
    private static void increaseAbility(int ability) {
        ability +=2;
        Console.WriteLine("ability in increaseAbility: {0}", ability);
    }



    }

   
}
