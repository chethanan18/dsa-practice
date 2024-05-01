using System; 
using System.Collections.Generic;

public class StackDataStructure
{
    public static void Main()
    {
        //Stack is LIFO that is Last In First Out
        //Stores data into vertical structure
        //Push() to add to the top
        //Pop() to remove from the top
        Stack<string> stk = new Stack<string>();

        //Add names to stack
        stk.Push("John");
        stk.Push("Marie");
        stk.Push("Raj");
        stk.Push("Robert");

        //Print stack items
        Console.WriteLine("Before deletion");
        foreach(var names in stk)
        Console.WriteLine(names);
        
        //Remove the top item
        stk.Pop();

        //Print stack items
        Console.WriteLine("After deletion");
        foreach(var names in stk)
        Console.WriteLine(names);
    }
}