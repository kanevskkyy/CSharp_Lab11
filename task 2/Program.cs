using System;
using System.Reflection;
using task_2;

class Task
{
    static void Main()
    {
        Type blackBoxType = typeof(BlackBoxInteger);

        ConstructorInfo constructor = blackBoxType.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { }, null);
        object blackBoxInstance = constructor.Invoke(null);

        FieldInfo innerValueField = blackBoxType.GetField("innerValue", BindingFlags.Instance | BindingFlags.NonPublic);
        
        while (true)
        {
            Console.Write("Enter = ");
            string[] enteredInformation = Console.ReadLine().Split('_');
            if (enteredInformation[0] == "END") break;
            string methodName = enteredInformation[0];
            int value = int.Parse(enteredInformation[1]);

            MethodInfo method = blackBoxType.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic);
            method.Invoke(blackBoxInstance, new object[] { value });
            int innerValue = (int)innerValueField.GetValue(blackBoxInstance);
            Console.WriteLine("Result = " + innerValue);
            Line();
        }
    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}