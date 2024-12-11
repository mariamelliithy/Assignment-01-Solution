namespace Assignment_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine("Enter a Number");
            //int num;
            //bool flag = int.TryParse(Console.ReadLine(), out num);
            //Console.WriteLine("Your Entered Number Is  : " + num);
            //Console.WriteLine("flag : " + flag);
            #endregion

            #region Q2
            //the program will throw a FormatException, and the corresponding message will be displayed.

            //string input = "123abc";

            //Console.WriteLine("Input string: "+ input);

            //int result = int.Parse(input);
            //Console.WriteLine("Conversion successful: "+ result);
            #endregion

            #region Q3
            //The program will calculate the results of the addition, subtraction, multiplication, and division of two floating-point numbers.

            //double num1 = 5.75;
            //double num2 = 2.4;


            //double addition = num1 + num2;
            //double subtraction = num1 - num2;
            //double multiplication = num1 * num2;
            //double division = num1 / num2;


            //Console.WriteLine($"Numbers: {num1}, {num2}");
            //Console.WriteLine($"Addition: {addition}");
            //Console.WriteLine($"Subtraction: {subtraction}");
            //Console.WriteLine($"Multiplication: {multiplication}");
            //Console.WriteLine($"Division: {division}");
            #endregion

            #region Q4
            //Console.Write("Enter a string: ");
            //string inputString = Console.ReadLine();

            //Console.Write("Enter the starting position of the substring: ");
            //int startIndex = int.Parse(Console.ReadLine());

            //Console.Write("Enter the length of the substring: ");
            //int length = int.Parse(Console.ReadLine());


            //if (startIndex >= 0 && startIndex < inputString.Length && startIndex + length <= inputString.Length)
            //{
            //    string substring = inputString.Substring(startIndex, length);
            //    Console.WriteLine($"The extracted substring is: \"{substring}\"");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid start index or length for the substring.");
            //}
            #endregion

            #region Q5
            //Changing the copiedValue only affects its memory space, leaving originalValue unchanged.

            //int originalValue = 10;

            //int copiedValue = originalValue;

            //Console.WriteLine("Original Value: " + originalValue);
            //Console.WriteLine("Copied Value: " + copiedValue);


            //copiedValue += 5;


            //Console.WriteLine("\nAfter modifying the copied value:");
            //Console.WriteLine("Original Value: " + originalValue);
            //Console.WriteLine("Copied Value: "+ copiedValue);
            #endregion

            #region Q6
            #endregion

            #region Q7
            //Console.Write("Enter the first string: ");
            //string str1 = Console.ReadLine();

            //Console.Write("Enter the second string: ");
            //string str2 = Console.ReadLine();

            //string combinedString = str1 + " " + str2;

            //Console.WriteLine("Combined string: " + combinedString);
            #endregion

            #region Q8
            //Console.Write("Enter the principal amount: ");
            //double principal = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the rate of interest (in %): ");
            //double rate = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the time (in years): ");
            //double time = Convert.ToDouble(Console.ReadLine());

            //double interest = (principal * rate * time) / 100;

            //Console.WriteLine($"\nThe simple interest is: {interest}");
            #endregion

            #region Q9
            //Console.Write("Enter your weight in kilograms: ");
            //double weight = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter your height in meters: ");
            //double height = Convert.ToDouble(Console.ReadLine());

            //double bmi = weight / (height * height);

            //Console.WriteLine($"\nYour BMI is: {bmi:F2}");

            //if (bmi < 18.5)
            //{
            //    Console.WriteLine("You are underweight.");
            //}
            //else if (bmi >= 18.5 && bmi < 24.9)
            //{
            //    Console.WriteLine("You have a normal weight.");
            //}
            //else if (bmi >= 25 && bmi < 29.9)
            //{
            //    Console.WriteLine("You are overweight.");
            //}
            //else
            //{
            //    Console.WriteLine("You are obese.");
            //}
            #endregion

            #region Q10
            //Console.Write("Enter the temperature in degrees: ");
            //int temperature = Convert.ToInt32(Console.ReadLine());

            //string result = (temperature < 10) ? "Just Cold" : (temperature > 30) ? "Just Hot" : "Just Good";

            //Console.WriteLine($"The temperature is: {result}");
            #endregion

            #region Q11
            //Console.Write("Enter the date (dd/mm/yyyy): ");
            //string userInput = Console.ReadLine();

            //DateTime date;
            //if (DateTime.TryParse(userInput, out date))
            //{
            //    Console.WriteLine($"Today's date : {date:dd}, {date:MM}, {date:yyyy}");
            //    Console.WriteLine($"Today's date : {date:dd} / {date:MM} / {date:yyyy}");
            //    Console.WriteLine($"Today's date : {date:dd} – {date:MM} – {date:yyyy}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid date format entered. Please use dd/mm/yyyy.");
            //}
            #endregion

            #region Q12
            // (c) The event is on 06/14/2024
            #endregion

            #region Q13
            // (e) A value 0 will be assigned to d.
            #endregion

            #region Q14
            // (d) 6 1
            #endregion

            #region Q15
            // (c) 6 6
            #endregion

        }
    }
}
