 class Division
  {
    static void Main(string[] args)
    {
      Console.WriteLine("This program will divide the first number by the second! Input the first number");
      string input1 = Console.ReadLine();

      Console.WriteLine("Input the second number now!");
      string input2 = Console.ReadLine();

      try
      {
          int number1 = Convert.ToInt32(input1);
          int number2 = Convert.ToInt32(input2);

          int answer = Divide(number1, number2);
          Console.WriteLine($"{number1} divided by {number2} equals to {answer}");

      }
      catch (FormatException ex)
      {
          Console.WriteLine("Error: One of your two inputs was not a number! Please restart and try again.");
          Console.WriteLine($"More detailed information: {ex.Message}");
      }
      catch (DivideByZeroException ex)
      {
          Console.WriteLine("You cannot divide by zero, unfortunately! Please restart and try again.");
          Console.WriteLine($"More detailed information: {ex.Message}");
      }
      catch (OverflowException ex)
      {
          Console.WriteLine("The numbers inputted became too big and caused a stack overflow! Please restart and try again.");
          Console.WriteLine($"More detailed information: {ex.Message}");
      }
      catch (NotFiniteNumberException ex)
      {
          Console.WriteLine("You cannot use infinity or nonintegers for this program. Please restart and try again.");
          Console.WriteLine($"More detailed information: {ex.Message}");
      }
        catch (Exception ex)
      {
          Console.WriteLine("An unexpected error occurred! Please restart and try again.");
          Console.WriteLine($"More detailed information: {ex.Message}");
      }

      Console.WriteLine("Press any key to end the program.");
      Console.ReadKey();
  }

  static int Divide(int a, int b)
  {
      return a / b;
    }    
  }
