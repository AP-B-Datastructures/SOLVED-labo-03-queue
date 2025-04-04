using Queue.library;

internal class Program
{
    private static void Main(string[] args)
    {
        MultipleQueues();

        Optelmachine();

    }

    private static void Optelmachine()
    {
        var q1 = new QueueInt();

        var input = "";

        while (input != "Q")
        {
            Console.WriteLine("pick a number (Q to stop)");
            input = Console.ReadLine();
        }

        var sum = 0;
        while (q1.Length > 0)
        {
            sum += q1.Dequeue();
        }
        Console.WriteLine(sum.ToString());
    }

    private static void MultipleQueues()
    {

        var q1 = new QueueString();
        var q2 = new QueueString();

        while (q1.Length + q2.Length < 10)
        {
            Console.WriteLine($"write a word ({10 - (q1.Length + q2.Length)} more)");
            var input = Console.ReadLine();
            if (input.Length > 5)
                q2.Enqueue(input);
            else
                q1.Enqueue(input);
        }

        Console.WriteLine("---------------------");
        Console.WriteLine("PRINTING");
        Console.WriteLine("---------------------");
        while (q1.Length > 0)
        {
            Console.WriteLine(q1.Dequeue());
        }
        while (q2.Length > 0)
        {
            Console.WriteLine(q2.Dequeue());
        }
    }
}