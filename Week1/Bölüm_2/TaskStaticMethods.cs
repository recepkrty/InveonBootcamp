using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week1.Bölüm_2
{
    internal class TaskStaticMethods
    {
        // 1. Task.Run
        public static async Task RunExample()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Running a background task.");
                Thread.Sleep(1000);
            });
            Console.WriteLine("Background task completed.");
        }

        // 2. Task.Delay
        public static async Task DelayExample()
        {
            Console.WriteLine("Waiting for 2 seconds...");
            await Task.Delay(2000);
            Console.WriteLine("Wait completed.");
        }

        // 3. Task.WhenAll
        public static async Task WhenAllExample()
        {
            var task1 = Task.Run(() => { Thread.Sleep(1000); Console.WriteLine("Task 1 completed."); });
            var task2 = Task.Run(() => { Thread.Sleep(2000); Console.WriteLine("Task 2 completed."); });
            await Task.WhenAll(task1, task2);
            Console.WriteLine("All tasks completed.");
        }

        // 4. Task.WhenAny
        public static async Task WhenAnyExample()
        {
            var task1 = Task.Run(() => { Thread.Sleep(1000); Console.WriteLine("Task 1 completed."); });
            var task2 = Task.Run(() => { Thread.Sleep(2000); Console.WriteLine("Task 2 completed."); });
            var completedTask = await Task.WhenAny(task1, task2);
            Console.WriteLine($"First completed task: {completedTask.Id}");
        }

        // 5. Task.FromResult
        public static void FromResultExample()
        {
            var completedTask = Task.FromResult(42);
            Console.WriteLine($"Task result: {completedTask.Result}");
        }

        // 6. Task.CompletedTask
        public static async Task CompletedTaskExample()
        {
            Console.WriteLine("Executing a completed task...");
            await Task.CompletedTask;
            Console.WriteLine("Completed task executed.");
        }

        // 7. Task.FromException
        public static void FromExceptionExample()
        {
            var faultedTask = Task.FromException(new Exception("An error occurred."));
            try
            {
                faultedTask.Wait();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine($"Exception caught: {ex.InnerException?.Message}");
            }
        }

        // 8. Task.FromCanceled
        public static void FromCanceledExample()
        {
            var cts = new CancellationTokenSource();
            cts.Cancel();
            var canceledTask = Task.FromCanceled(cts.Token);
            Console.WriteLine($"Task canceled: {canceledTask.IsCanceled}");
        }
    }
}

