namespace Lab_02_Basic
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello, World!");
    //    }
    //}

    // 1. Write a program to change the case of entered character.
    class Task1
    {
        static void Main()
        {
            Console.WriteLine("Enter Character : ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (char.IsUpper(ch))
            {
                Console.WriteLine($"Lowercase: {char.ToLower(ch)}");
            }
            else if (char.IsLower(ch))
            {
                Console.WriteLine($"Uppercase : {char.ToUpper(ch)}");
            }
            else
            {
                Console.WriteLine("Not an Alphabet.");
            }
        }
    }

    // 2. Write a program to Replace lower case characters to upper case and Vice-versa.
    class Task2
    {
        static void Main()
        {
            Console.WriteLine("Enter String : ");
            string word = Console.ReadLine() ?? ""; // Handle null input
            string s2 = "";

            foreach (char i in word)
            {
                if (char.IsUpper(i))
                {
                    s2 += char.ToLower(i);
                }
                else if (char.IsLower(i))
                {
                    s2 += char.ToUpper(i);
                }
                else
                {
                    s2 += i;
                }
            }

            Console.WriteLine("Toggle String : " + s2);
        }
    }

    // 3. Take 2 strings from the user, and validate 2nd string is contains by 1st or not.
    class Task3
    {
        static void Main()
        {
            Console.WriteLine("Enter String1 : ");
            string s1 = Console.ReadLine() ?? ""; // Handle null input

            Console.WriteLine("Enter String2 : ");
            string s2 = Console.ReadLine() ?? ""; // Handle null input

            if (s1.Contains(s2))
            {
                Console.WriteLine($"Result: {s2} IS contained in {s1}");
            }
            else
            {
                Console.WriteLine($"{s2} is NOT contained in {s1}");
            }
        }
    }

    // 4. Find the second largest element from an array.
    class Task4
    {
        static void Main()
        {
            Console.Write("Enter Number Of Elements : ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter Element Of Array : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Array.Sort(arr);
            //Console.WriteLine("Second Largest : " + arr[size - 2]);

            int largest = int.MinValue;
            int second = int.MinValue;
            foreach (int i in arr)
            {
                if (i > largest)
                {
                    second = largest;
                    largest = i;
                }
                else if (i > second)
                    second = i;
            }

            Console.WriteLine($"Second Largest : {second}");
        }
    }

    // 5. Write a program to create a Simple Calculator for two numbers
    // (Addition, Multiplication, Subtraction, Division)[using elseif ladder &Switch Case]
    class Task5
    {
        static void Main()
        {
            Console.Write("Enter First Number : ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Operator : ");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Enter Seocnd Number : ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine("Sum : " + (n1 + n2));
                    break;
                case '-':
                    Console.WriteLine("Dif : " + (n1 - n2));
                    break;
                case '*':
                    Console.WriteLine("Mul : " + (n1 * n2));
                    break;
                case '/':
                    Console.WriteLine("Sum : " + (n1 / n2));
                    break;
                default:
                    Console.WriteLine("Enter Valid Operator.");
                    break;
            }
        }
    }

    // 6. Find the sum of all elements in an array.
    class Task6
    {
        static void Main()
        {
            Console.WriteLine("Enter Number Of Elements : ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter Element Of Array : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());

                sum += arr[i];
            }

            Console.WriteLine("Sum Of All Elements = " + sum);


            //int[] arr2 = { 10, 20, 30, 40, 50 };
            //int sum2 = arr2.Sum();
            //Console.WriteLine("Sum Of All Elements = " + sum2);
        }
    }


    // 7. Count odd and even numbers in an array.
    class Task7
    {
        static void Main()
        {
            Console.Write("Enter Number Of Elements : ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter Element Of Array : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int oddCount = 0;
            int evenCount = 0;

            for (int i = 0; i < size; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            Console.WriteLine($"Total Odd Count : {oddCount}");
            Console.WriteLine($"Total Even Count : {evenCount}");
        }
    }

    // 8. Write a program which find out the first and last occurrence of a character
    // and then replace that character with ‘D’.
    class Task8
    {
        static void Main()
        {
            Console.Write("Enter a String: ");
            string str = Console.ReadLine() ?? ""; // Handle null input

            Console.Write("Enter Character To Find: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();

            int first = str.IndexOf(ch);
            int last = str.LastIndexOf(ch);

            char[] arr = str.ToCharArray();

            arr[first] = 'D';
            arr[last] = 'D';

            string result = new string(arr);

            Console.WriteLine("First Position : " + first);
            Console.WriteLine("Last Position  : " + last);
            Console.WriteLine("Modified String: " + result);
        }
    }

    // Extra : 
    class ArrayToDo
    {
        static void Main()
        {

            int[] arr = { };
            int size;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("ARRAY Menu-Driven");
                Console.WriteLine("1. Input Array");
                Console.WriteLine("2. Display Sum");
                Console.WriteLine("3. Count Odd and Even");
                Console.WriteLine("4. Find Second Largest");
                Console.WriteLine("5. Exit");
                Console.Write("Enter Your Choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Size of Array: ");
                        size = Convert.ToInt32(Console.ReadLine());

                        arr = new int[size];

                        for (int i = 0; i < size; i++)
                        {
                            Console.Write("Enter Element : ");
                            arr[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        break;

                    case 2:

                        int sum = 0;

                        for (int i = 0; i < arr.Length; i++)
                        {
                            sum += arr[i];
                        }

                        Console.WriteLine("Sum = " + sum);
                        break;

                    case 3:

                        int odd = 0, even = 0;

                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (arr[i] % 2 == 0)
                            {
                                even++;
                            }
                            else
                            {
                                odd++;
                            }
                        }

                        Console.WriteLine("Even Count = " + even);
                        Console.WriteLine("Odd Count = " + odd);
                        break;

                    case 4:

                        int largest = int.MinValue;
                        int second = int.MinValue;
                        foreach (int i in arr)
                        {
                            if (i > largest)
                            {
                                second = largest;
                                largest = i;
                            }
                            else if (i > second)
                                second = i;
                        }

                        Console.WriteLine($"Second Largest : {second}");
                        break;

                    case 5:
                        Console.WriteLine("Program Ended.");
                        return;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
        }
    }
}