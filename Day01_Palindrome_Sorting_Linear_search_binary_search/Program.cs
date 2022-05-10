
PalindromeTest();

void PalindromeTest()
{
    // Palindrome

    Console.Write("Enter a string: ");
    string s = Console.ReadLine();

    Console.WriteLine(s + ": " + IsPalindrome(s));
    s = "nitin";
    Console.WriteLine(s + ": " + IsPalindrome(s));
    s = "avinash";
    Console.WriteLine(s + ":" + IsPalindrome(s));

    bool IsPalindrome(string s)
    {
        int startIndex = 0;
        int endIndex = s.Length - 1;
        while (startIndex < endIndex)
        {
            if (s[startIndex++] != s[endIndex--])
                return false;
        }

        return true;
    }
}

//-----------------------------------------------------------------

//LinearSerchTest();

void LinearSerchTest()
{
    // Linear Search

    string[] fruits = new string[]
    {
        "Apples",
        "PineApples",
        "Mangoes",
    };

    Console.Write("Enter a fruit to search: ");
    string fruitToSearch = Console.ReadLine();


    if (IsFound(fruits, fruitToSearch))
        Console.WriteLine("Found");
    else
        Console.WriteLine("Not Found");


    bool IsFound(string[] fruits, string fruitToSearch)
    {
        foreach (string fruit in fruits)
        {
            if (fruitToSearch == fruit)
            {
                return true;
            }
        }

        return false;
    }
}


//-----------------------------------------------------------------

//SortingTest();

void SortingTest()
{
    /* Sorting 0*/

    int[] arr = new int[] { 55, 22, 22, 78, 88, 22, 88, 44, 54, 86, 23 };

    Console.Write("Original array: ");
    Display(arr);

    Sort(arr, true);
    Console.Write("Sorted ascending array: ");
    Display(arr);

    Sort(arr, false);
    Console.Write("Sorted descending array: ");
    Display(arr);

    void Sort(int[] arr, bool ascending)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (ascending)
                {
                    if (arr[j] < arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                else
                {
                    if (arr[j] > arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
    }

    void Display(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write(num + ",");
        }
        Console.WriteLine();
    }
}

//-----------------------------------------------------------------

//ForLoopTest();

void ForLoopTest()
{
    for (int i = 1; i <= 30; i++)
    {
        Console.WriteLine("Hello >> " + i);
    }
}


//-----------------------------------------------------------------

//ArrayTest();

void ArrayTest()
{

    /* Array example */
    int num;    // declaration of variable
    num = 10;   // assigment of value to variable
    int num2 = 20;   // initialization of variable
    int[] abc;   //declaring an array variable abc

    int[] xyz = new int[10];  // declaring and allocation an array of 10 elements

    int[] mno = new int[] { 11, 55, 66, 44, 33, 220 }; // declare and initialize array

    for (int i = 0; i < mno.Length; i++)  //print array using for loop
    {
        Console.WriteLine("using for loop : " + mno[i]);
    }

    Console.WriteLine("\n");
    foreach (int n in mno)  //print array using for each
    {
        Console.WriteLine("using for each : " + n);
    }
}


//-----------------------------------------------------------------

//Arrray2();

void Arrray2()
{
    /* Array with for example */
    string[] arr = new string[] { "Apple", "Mango", "Car", "Bike" };

    foreach (string s in arr)
    {
        Console.WriteLine(s);
    }

    foreach (string s in arr)
    {
        if (s[0] != 'A')
        {
            Console.WriteLine(s);
        }
    }
}

    //-----------------------------------------------------------------

   // DynamicInput();

    void DynamicInput()
    {

        Console.Write("Enter your age: 0");   //enter data console
        string ageText = Console.ReadLine();  // enter data read console

        int age = int.Parse(ageText);  //type casting means change datatype

        if (age > 18)
            Console.WriteLine("You can enter");
        else
            Console.WriteLine("Get out!!!");
    }
//-----------------------------------------------------------------

/* Example. Accept two numbers and display division result */

//Division();

void Division()
{
    Console.Write("Enter a number: ");
    string num1 = Console.ReadLine();

    Console.Write("Enter another number: ");
    string num2 = Console.ReadLine();

    int ans = int.Parse(num1) / int.Parse(num2);

    Console.WriteLine("Ans = " + ans);
}







