# Parallel-programming-CSharp
Parallel programming and thread safety in C#.

## Instructions
To run the code without thread safety, run `dotnet run -- 1`. This will print 'Done' twice because the same code was accessed by two different threads (the main thread and a new thread).

To run the code with thread safety implemented, run `dotnet run -- 0`. This will only print 'Done' once because of the use of `lock` to shield part of the code from other threads.
