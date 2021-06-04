using System;

namespace Hw08_DecisionStructure2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Number:");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"The Number entered: {number}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message.ToString()}");
            }
            finally
            {
                Console.WriteLine("Process completed");
            }

            try
            {
                int number1 = int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Enter blank value");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("The data type is not suitable");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("The value range is out of bounds");
                Console.WriteLine(ex);
            }
            finally{
                Console.WriteLine("Process Completed");
            }
        }
    }
}
