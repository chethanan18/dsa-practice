using System;

public class QueueDataStructure
{
    public static void Main()
    {
        //Queue is FIFO - First In First Out
        Queue<int> queue = new Queue<int>();

        //Enqueue Operation
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        Console.WriteLine("Enqueue Operation:");
        foreach(var item in queue)
        Console.WriteLine(item);

        //Dequeue Operation
        queue.Dequeue();
        Console.WriteLine("Dequeue Operation:");
        foreach(var item in queue)
        Console.WriteLine(item);
        
    }
}