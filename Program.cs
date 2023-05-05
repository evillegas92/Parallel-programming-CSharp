internal class Program
{
    private static void Main(string[] args)
    {
        int programOption = -1;
        bool parsed = args.Length > 0 && int.TryParse(args[0], out programOption);
        if (!parsed) {
            Console.WriteLine("Incorrect input option.");
            return;
        }
        switch (programOption) {
            case (0): {
                ThreadSafe.Run();
            }
            break;
            case (1): {
                ThreadUnSafe.Run();
            }
            break;
            default:
                Console.WriteLine("Incorrect input option.");
            break;
        }
    }
}