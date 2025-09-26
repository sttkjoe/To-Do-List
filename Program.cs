class Program
{
    static List<string> tasks = new List<string>();
    static List<bool> tasksStatus = new List<bool>();

    public static void Main(string[] args)
    {
        while(true)
        {
            Console.WriteLine("Task Manager");
            Console.WriteLine("1: Add a task with a description.");
            Console.WriteLine("2: Mark a task as completed.");
            Console.WriteLine("3: View all tasks.");
            Console.WriteLine("4: Exit the program.");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    MarkTaskAsCompleted();
                    break;
                case "3":
                    ViewTasks();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try a number from the list.");
                    break;
            }

            static void AddTask()
            {
                Console.WriteLine("Enter task's description: ");
                string? task = Console.ReadLine();
                tasks.Add(task);
                tasksStatus.Add(false);
                Console.WriteLine("Task added successfully");
            }

            static void MarkTaskAsCompleted()
            {
                if (tasks.Count == 0)
                {
                    Console.WriteLine("No tasks to be found.");
                    return;
                }

                Console.WriteLine("Enter the task number to mark as completed: ");
                if(int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber <= tasks.Count 
                && taskNumber > 0)
                {
                    tasksStatus[taskNumber - 1] = true;
                    Console.WriteLine("Task" + taskNumber + " has been marked as completed!");
                }
                else
                {
                    Console.WriteLine("Invalid task number.");
                }
            }

            static void ViewTasks()
            {
                if (tasks.Count == 0)
                {
                    Console.WriteLine("No tasks to be found.");
                    return;
                }

                Console.WriteLine("Tasks:");
                for (int i = 0; i < tasks.Count; i++)
                {
                    string status = tasksStatus[i] ? "Completed" : "Pending";
                    Console.WriteLine(i + 1  + ": " + tasks[i]);
                    Console.WriteLine("Status: " + status);
                    Console.WriteLine("");
                }
            }

        }
    }
}
