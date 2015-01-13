using System;


namespace COMP123_Lesson02
{
    class Program
    {

        static void Main()
        {
            int strength;
            int stamina = 10;
            int speed = 5;
            int toughness = 12;
            int intelligence = 2;

            setAbility(out strength, 50);


            Console.WriteLine("Strength in main before: {0}", strength);


            increaseAbility( ref strength, "Strength");


            Console.WriteLine("Strength in main after: {0}", strength);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }


        // Takes two parameters and sets the value of the ability that is passed
        private static void setAbility(out int abilityName, int abilityValue) {
            abilityName = abilityValue;
        }


        // method to increase an ability by 2;
    private static void increaseAbility(ref int abilityScore, String abilityName) {
        abilityScore +=2;
        Console.WriteLine("{0} in increaseAbility: {1}", abilityName, abilityScore);
    }



    }

   
}
