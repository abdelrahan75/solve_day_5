using System.Runtime.InteropServices.Marshalling;

namespace ConsoleApp1
{
    internal class Program
    {
        //static void SumAndMultiply(int a, int b, out int sum, out int product)
        //{
        //    sum = a + b;
        //    product = a * b;
        //}

        //static void PrintString(string text, int times = 5)
        //{
        //    for (int i = 0; i < times; i++)
        //        Console.WriteLine(text);
        //}

        //static int SumArray(params int[] numbers)
        //{
        //    int sum = 0;
        //    foreach (int num in numbers)
        //        sum += num;
        //    return sum;
        //}
        static void Main(string[] args)
        {

            #region part_1
            #region problem_1 

            //int x, y;

            //bool flag1 ; 
            //bool flag2 ;
            //int sum;
            //do
            //{
            //    Console.WriteLine("acess intger number");
            //    flag1 = int.TryParse(Console.ReadLine(), out x);
            //    flag2 = int.TryParse(Console.ReadLine(), out y);
            //}
            //while (!flag2 && !flag1);

            //try
            //{
            //     sum = x / y;
            //    Console.WriteLine(sum);
            //}
            //catch(DivideByZeroException ex) {

            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    if (x == 0 || y == 0)
            //    Console.WriteLine("Operation not  complete");
            //    else
            //    {
            //        Console.WriteLine("operation is complete ");
            //    }
            //}

            //A finally block always executes, regardless of whether an exception is thrown.

            #endregion

            #region problem_2 

            //TestDefensiveCode();

            //static void TestDefensiveCode()
            //{
            //    try
            //    {
            //        Console.Write("Enter value for X (must be positive): ");
            //        int x = int.Parse(Console.ReadLine());
            //        if (x <= 0)
            //        {
            //            throw new ArgumentException("X must be a positive integer (greater than 0).");
            //        }
            //        Console.Write("Enter value for Y (must be greater than 1): ");
            //        int y = int.Parse(Console.ReadLine());
            //        if (y <= 1)
            //        {
            //            throw new ArgumentException("Y must be greater than 1.");
            //        }

            //        int result = x / y;

            //        Console.WriteLine($"Result: {x} / {y} = {result}");
            //    }
            //    catch (ArgumentException ex)
            //    {
            //        Console.WriteLine($"Validation Error: {ex.Message}");
            //    }
            //    catch (DivideByZeroException)
            //    {
            //        Console.WriteLine("Error: Cannot divide by zero.");
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Error: Please enter valid integers only.");
            //    }
            //    finally
            //    {
            //        Console.WriteLine("Operation complete");
            //    }
            //}
            //
            //int.TryParse() improves program robustness compared to int.Parse() mainly
            //because it avoids exceptions for invalid input and provides a safe, predictable way to handle parsing failures.

            #endregion

            #region problem_3
            ////int? x = null;
            ////int y = x ?? default;
            //HasValue : Safely checks if the nullable has a value before accessing it
            //Value : Retrieves the actual value, but throws InvalidOperationException if null

            //When there is no value (null), it cannot return anything, so it throws an exception.
            //System.InvalidOperationException
            #endregion

            #region problem_4 
            //int[] arr = new int[5];
            //try
            //{
            //    arr[7] = 1;
            //}
            //catch (IndexOutOfRangeException Ex)
            //{
            //    Console.WriteLine(Ex.Message);
            //}
            //Prevents Runtime Exceptions and not access element out size of arrey

            #endregion

            #region problem_5

            //   int[,] arr = new int[3, 3];
            //    Console.WriteLine("Enter 9 values:");
            //    for (int i = 0; i < 3; i++)
            //        for (int j = 0; j < 3; j++)
            //            arr[i, j] = int.Parse(Console.ReadLine());

            //    // Row sums
            //    Console.WriteLine("\nRow sums:");
            //    for (int i = 0; i < arr.GetLength(0); i++)
            //    {
            //        int sum = 0;
            //        for (int j = 0; j < arr.GetLength(1); j++)
            //            sum += arr[i, j];
            //        Console.WriteLine($"Row {i}: {sum}");
            //    }

            //    // Column sums
            //    Console.WriteLine("\nColumn sums:");
            //for (int j = 0; j < arr.GetLength(1); j++)
            //{
            //    int sum = 0;
            //    for (int i = 0; i < arr.GetLength(0); i++)
            //        sum += arr[i, j];
            //    Console.WriteLine($"Col {j}: {sum}");
            //}
            // is used with multi - dimensional arrays to get the number of elements in a specific dimension.
            #endregion

            #region problem_6
            //int[][] jagged = new int[3][];
            //jagged[0] = new int[2];
            //jagged[1] = new int[3];
            //jagged[2] = new int[4];

            //for (int i = 0; i < jagged.Length; i++)
            //{
            //    Console.WriteLine($"Row {i} ({jagged[i].Length} values):");
            //    for (int j = 0; j < jagged[i].Length; j++)
            //        jagged[i][j] = int.Parse(Console.ReadLine());
            //}


            //for (int i = 0; i < jagged.Length; i++)
            //{
            //    Console.Write($"Row {i}: ");
            //    for (int j = 0; j < jagged[i].Length; j++)
            //        Console.Write(jagged[i][j] + " ");
            //    Console.WriteLine();
            //            //}
            //            Use rectangular arrays when dimensions are fixed and performance is critical.
            //            Use jagged arrays when rows can have different lengths or when memory savings from uneven rows matter.
            #endregion

            #region problem_7
            //string? name = null;

            //Console.Write("Enter your name  ");
            //string input = Console.ReadLine()!;

            //if (! string.IsNullOrEmpty(input))
            //    name = input;

            //Console.WriteLine("\n");
            //if (name != null)
            //    Console.WriteLine($"Hello, {name}!");
            //else
            //    Console.WriteLine("No name ");

            //// Using null-forgiveness operator
            //Console.WriteLine($"\nLength: {name!.Length}");

            // is to help developers avoid NullReferenceException errors by making nullability explicit in the type system.
            #endregion

            #region problem_8

            //int num = 42;
            //object boxed = num;
            //Console.WriteLine($"Boxed value: {boxed}");
            //Console.WriteLine($"Type: {boxed.GetType()}");
            //int unboxed = (int)boxed;
            //Console.WriteLine($"\nUnboxed value: {unboxed}");
            //try
            //{
            //    double invalid = (double)boxed;
            //    Console.WriteLine($"Double: {invalid}");
            //}
            //catch (InvalidCastException ex)
            //{
            //    Console.WriteLine($"\nError: {ex.Message}");
            //}
            //Boxing Heap allocation + value copy High
            //Unboxing Type check + value copy
            //Boxing is generally more expensive than unboxing because it involves heap allocation.
            #endregion

            #region problem_9
            //int num1 = int.Parse(Console.ReadLine());

            //int num2 = int.Parse(Console.ReadLine());

            //SumAndMultiply(num1, num2, out int sum, out int product);

            //Console.WriteLine($"\nSum: {sum}");
            //Console.WriteLine($"Product: {product}");
            //"This method will assign a value to this variable."
            //The method must assign a value to the out parameter before it exits.

            // Otherwise, a compile-time error will occur.
            #endregion

            #region problem_10 
            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //PrintString(input);
            //PrintString(input, 3);
            //PrintString(times: 2, text: input);
            //f an optional parameter appears before a required parameter,
            //the compiler cannot determine which argument corresponds to which parameter.
            #endregion

            #region problem_11
            //int?[] arr = default;
            //for (int i = 0;i < arr?.Length ; i++) {
            //    bool Flag = int.TryParse(Console.ReadLine(), out int value);
            //    if (Flag)
            //    {
            //        arr[i] = value;
            //    }
            //    else
            //    {
            //        arr[i] = null;
            //    }
            //}

            //If the object is NOT null → access the property or method normally

            //If the object is null → return null instead of throwing an exception

            #endregion

            #region problem_12
            //Console.Write("Enter a day of the week: ");
            //string day = Console.ReadLine();

            //int dayNumber = day.ToLower() switch
            //{
            //    "monday" => 1,
            //    "tuesday" => 2,
            //    "wednesday" => 3,
            //    "thursday" => 4,
            //    "friday" => 5,
            //    "saturday" => 6,
            //    "sunday" => 7,
            //    _ => 0
            //};

            //if (dayNumber == 0)
            //    Console.WriteLine("Invalid day!");
            //else
            //    Console.WriteLine($"{day} is day number {dayNumber}");
            //
            //A switch expression is preferred over a traditional if statement when you are comparing one variable against multiple possible values and want a cleaner,
            //shorter, and more readable way to return a result.
            #endregion


            #region problem_13
            //int result2 = SumArray(5, 15, 25, 35, 45);
            //Console.WriteLine($"Sum (individual): {result2}");

            //// Calling with an array
            //int[] arr = { 100, 200, 300 };
            //int result3 = SumArray(arr);
            //Console.WriteLine($"Sum (array): {result3}");

            //// Calling with no arguments
            //int result4 = SumArray();
            //Console.WriteLine($"Sum (empty): {result4}");
            #endregion

            #endregion

            #region part_2

            #region problem_1
            //int[] arr = new int[6];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int value;
            //    bool flag  = int.TryParse(Console.ReadLine(), out value);
            //    if (flag)
            //    {
            //        if (value > 0)
            //        {
            //            arr[i] = value; 
            //        }
            //    }

            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            #endregion

            #region problme_2

            //int num;
            //int value;
            //bool flag = int .TryParse(Console.ReadLine(), out value);
            //if (flag)
            //{
            //    if (value != 0)
            //    {
            //        for (int i = 0; i < 12; i++)
            //        {
            //            num = value * i;
            //            Console.Write( $"{num} , ");
            //        }
            //    }
            //}
            #endregion

            #region problem_3 
            //int num= int.Parse(Console.ReadLine());
            //for (int i=1;i <= num;i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region problme_4
            //int num1, num2;
            //num1= int.Parse(Console.ReadLine());
            //num2 = int.Parse(Console.ReadLine());
            //double result  = Math.Pow(num1, num2);
            //Console.WriteLine(result);
            #endregion

            #region problem_5
            //string s = Console.ReadLine();

            //for (int i=s.Length-1; i>=0; i--)
            //{
            //    Console.Write(s[i]);
            //}
            #endregion

            #region problem_6

            //string s = Console.ReadLine();

            //    for (int i = s.Length - 1; i >= 0; i--)
            //    {
            //        Console.Write(s[i]);
            //    } 

            // or 




            #endregion

            #region problem_7
            //Console.Write("Enter array size: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //Console.WriteLine("Enter array elements:");
            //for (int i = 0; i < n; i++)
            //    arr[i] = int.Parse(Console.ReadLine());

            //int maxDist = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int dist = j - i - 1;
            //            if (dist > maxDist)
            //                maxDist = dist;
            //        }
            //    }
            //}

            //Console.WriteLine($"\nLongest distance: {maxDist}");
            #endregion

            #region problem_8
            //Console.Write("Enter a sentence: ");
            //string sentence = Console.ReadLine();

            //string[] words = sentence.Split(' ');
            //Array.Reverse(words);

            //Console.WriteLine(string.Join(" ", words));
            #endregion




            #endregion
        }
    }
}
