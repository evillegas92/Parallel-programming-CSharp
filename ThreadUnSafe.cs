public class ThreadUnSafe
{
    static bool done; // static fields are shared between all threads.

    public static void Run()
    {
        Thread t = new Thread(DoWork);
        t.Start();

        // do other work on the main thread
        DoWork();
    }

    static void DoWork()
    {
        if (!done) {
            Console.WriteLine("Done");
            done = true;
        }
    }
}