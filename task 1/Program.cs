using System;
using System.Reflection;
using task_1;

class Task
{
    static void Main()
    {
        Type myType = typeof(HarvestFields);
        FieldInfo[] privatesFields = myType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        FieldInfo[] protectedFields = myType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        FieldInfo[] publicFields = myType.GetFields(BindingFlags.Public | BindingFlags.Instance);

        while (true)
        {
            Console.Write("Enter = ");
            string[] enteredInformation = Console.ReadLine().Split();
            if (enteredInformation[0].ToLower() == "harvest") break;
            else if (enteredInformation[0].ToLower() == "private") showPrivates(privatesFields);
            else if (enteredInformation[0].ToLower() == "protected") showProtected(protectedFields);
            else if (enteredInformation[0].ToLower() == "public") showPublic(publicFields);
            else Console.WriteLine("Wrong command");
            Line();
            Console.Write("Press enter to continue ...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    public static void showPublic(FieldInfo[] publicFields)
    {
        foreach (FieldInfo field in publicFields)
        {
            if (field.IsPublic) Console.WriteLine($"public {field}");
        }
    }

    public static void showProtected(FieldInfo[] protectedFields)
    {
        foreach (FieldInfo field in protectedFields)
        {
            if(field.IsFamily) Console.WriteLine($"protected {field}");
        }
    }

    public static void showPrivates(FieldInfo[] privatesFields)
    {
        foreach (FieldInfo item in privatesFields)
        {
            if (item.IsPrivate) Console.WriteLine($"private {item}");
        }
    }

    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}