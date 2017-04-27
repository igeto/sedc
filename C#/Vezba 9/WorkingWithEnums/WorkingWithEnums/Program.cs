using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Todo> todoItems = new List<Todo>()
            {
                new WorkingWithEnums.Todo() {Description = "Task 1", EstimatedHours = 6, Status = StatusEnum.NotStarted},
                new WorkingWithEnums.Todo() {Description = "Task 2", EstimatedHours = 8, Status = StatusEnum.NotStarted },
                new WorkingWithEnums.Todo() {Description = "Task 3", EstimatedHours = 12, Status = StatusEnum.OnHold },
                new WorkingWithEnums.Todo() {Description = "Task 4", EstimatedHours = 2, Status = StatusEnum.InProgress },
                new WorkingWithEnums.Todo() {Description = "Task 5", EstimatedHours = 5, Status = StatusEnum.Completed },
                new WorkingWithEnums.Todo() {Description = "Task 6", EstimatedHours = 7, Status = StatusEnum.OnHold },
                new WorkingWithEnums.Todo() {Description = "Task 7", EstimatedHours = 3, Status = StatusEnum.InProgress }
            };
            PrintTodoList(todoItems);
            Console.WriteLine("Cast to enum: " + (StatusEnum)1);
            Console.ReadLine();
        }
        static void PrintTodoList(List<Todo> todos)
        {
            foreach (var todo in todos)
            {
                switch (todo.Status)
                {
                    case StatusEnum.NotStarted:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case StatusEnum.InProgress:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case StatusEnum.OnHold:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case StatusEnum.Completed:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case StatusEnum.Deleted:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    default:
                        break;
                }
                Console.WriteLine(todo.Description + " " + (int)todo.Status);
            }
        }
    }
}
