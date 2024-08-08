namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            String name = "Anthony";
            int age = 27;
            char middleInitial = 'J';
            bool isOver21 = true;
            double currentTemp = 75.9;
            decimal currentPrice = 28.99m;
            
            

            //String interpolation
            
            Console.WriteLine($"My name is {name} and I am {age} years old \n" +
                              $"My Initial name is {middleInitial}");
            Console.WriteLine($"I am above the age of 21 which is {isOver21} \n" +
                              $"The current temperature is {currentTemp} and current price for silver is {currentPrice} dollars");
        }
    }
    
}
