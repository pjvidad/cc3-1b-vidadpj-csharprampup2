namespace CSharpRampUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("Pounds to Kilograms Converter");
            Console.WriteLine("========================================");
            Console.Write("Enter weight in pounds: ");
            float weight_lbs = float.Parse(Console.ReadLine());
            float weight_converter = 2.205f;

            float weight_kg = weight_lbs / weight_converter;
            Console.WriteLine("Weight in kg: " + Math.Round(weight_kg, 2) + "kg");

            Console.WriteLine("========================================");
            Console.WriteLine("Miles to Kilometers Converter");
            Console.WriteLine("========================================");
            Console.Write("Enter length in miles: ");
            float length_mi = float.Parse(Console.ReadLine());
            float length_converter = 1.609f;

            float length_km = length_mi * length_converter;
            Console.WriteLine("Length in km: " + Math.Round(length_km, 2) + "km");

            Console.WriteLine("========================================");
            Console.WriteLine("Fahrenheit to Celsius Converter");
            Console.WriteLine("========================================");
            Console.Write("Enter temperature in Fahrenheit: ");
            float temp_f = float.Parse(Console.ReadLine());
            float temp_c = (temp_f - 32) * 5 / 9;

            Console.WriteLine("Temperature in Celsius: " + Math.Round(temp_c, 2) + "°C");
            Console.WriteLine("========================================");
            Console.WriteLine("Calculating the Average Age of 10 Students");
            Console.WriteLine("========================================");
            Console.Write("Age of Student 1: ");
            int S1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Age of Student 2: ");
            int S2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Age of Student 3: ");
            int S3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Age of Student 4: ");
            int S4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Age of Student 5: ");
            int S5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Age of Student 6: ");
            int S6 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Age of Student 7: ");
            int S7 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Age of Student 8: ");
            int S8 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Age of Student 9: ");
            int S9 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Age of Student 10: ");
            int S10 = Convert.ToInt32(Console.ReadLine());

            int average = S1 + S2 + S3 + S4 + S5 + S6 + S7 + S8 + S9 + S10 / 10;
            Console.WriteLine("The average age of students is: " + average);
            Console.WriteLine("========================================");
            Console.WriteLine(" ");

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine(" An Urban Fantasy Story of Devils");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

            string c_one = "<The Control Devil>", c_two = " <Gun Devil>", c_three = "<Blood Devil>", c_four = " <Hell Devil>", c_five = "<The Chainsaw Devil>";

            string gun_ability = " <Worldwide Shot Ability>", contract_name = "<Tactless Contract>", transformation = " <ChainsawMan Transformation>", makima_ability = "<One shot, One Kill>";
            string hell_ability = "<Cast Into Hell>", pleading = "\"Save me, Chainsaw Devil\"", chainsaw_ability = "<Five-Chainsaw Attack>", powerful_ability = "<Eat Existence Ability>";

            Console.WriteLine("As Makima, " + c_one + "prepares for ability activation, she was shot on the head by the" + c_two + "'s" + gun_ability + ".");
            Console.WriteLine("It was Makima's 29th recorded death. Makima's " + contract_name + " with the Prime Minister helped her to survive this fatal shot.");
            Console.WriteLine("In exchange for Makima's death, it would be passed to a random citizen.");
            Console.WriteLine("Controlled by Makima, Denji's" + transformation + " had appeared, executing the Gun Devil.");
            Console.WriteLine("Due to Makima's anger, she unleashed her " + makima_ability + " ability causing " + c_three + ", who just appeared from the door get killed.");
            Console.WriteLine("The Anti-Makima Squad tried to beat Makima by the ability, " + hell_ability + " getting help through " + c_four + ".");
            Console.WriteLine("But before they could win, " + c_one + " whispered under her breath, " + pleading);
            Console.WriteLine("Then and there, with the engine's roaring noise, the superhero of Hell appeared, " + c_five + ".");
            Console.WriteLine("Call him once, and he will come. Using his " + chainsaw_ability + c_four + " was cut into pieces within a nanosecond.");
            Console.WriteLine("But unbeknowst to Makima, the devils who called for help are cut up and killed too.");
            Console.WriteLine("Then so, " + powerful_ability + " kicked off, erasing " + c_one + " from existence.");
            Console.WriteLine("END OF STORY");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

            Console.WriteLine("========================================");
            Console.WriteLine("Right Triangle");
            Console.WriteLine("========================================");

            Console.Write("Enter the height of the triangle: ");
            int height = int.Parse(Console.ReadLine());

            if (height <= 0)
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                for (int column = 1; column <= height; column++)
                {
                    for (int row = 1; row <= column; row++)
                    {
                        Console.Write(row);
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine("========================================");
            Console.WriteLine("Summation");
            Console.WriteLine("========================================");

            int current = 1, sum = 0, last;
            string formula = "";
            Console.Write("Enter the nth number: ");
            last = int.Parse(Console.ReadLine());
            Console.WriteLine("input: " + last);

            if (last <= 0)
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                while (current <= last)
                {
                    formula += Convert.ToString(current);
                    if (current < last)
                    {
                        formula += " + ";
                    }
                    current++;
                }
                Console.WriteLine("formula: " + formula);

                for (current = 1; current <= last; current++)
                {
                    sum = sum + current;
                }
                Console.WriteLine("output: " + sum);
            }
            Console.WriteLine("========================================");
            Console.WriteLine("Inverse Right Triangle");
            Console.WriteLine("========================================");

            Console.Write("Enter the height of the reversed triangle: ");
            int rheight = int.Parse(Console.ReadLine());

            if (rheight <= 0)
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                for (int rcolumn = rheight; rcolumn >= 1; rcolumn--)
                {
                    for (int rrow = 1; rrow <= rcolumn; rrow++)
                    {
                        Console.Write(rrow);
                    }
                    Console.WriteLine();
                }
            }


        }
    }
}