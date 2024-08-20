
namespace Practice1
{
    class Program
    {
        static void Main(String[] Args)
        {
           
            Console.WriteLine("Please enter your weight in kilograms: \n");
            var weight = System.Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please enter your height in meters: \n");
            var height = System.Convert.ToDecimal(Console.ReadLine());

            var BMI = weight / (height * height);

            if (BMI < 18)
            {
                Console.WriteLine("Your BMI is: {0}), you have Underweight", BMI);
            }
            else if (BMI > 18 && BMI < 25)
            {
                Console.WriteLine("Your BMI is: {0}), you have Normal Weight", BMI);
            }
            else if (25 < BMI && BMI < 30)
            {
                Console.WriteLine("Your BMI is: {0}), you have Overweight", BMI);
            }
            else
            {
                Console.WriteLine("Your BMI is: {0}), you have Obesity", BMI);

            }
        }

    }

    
}