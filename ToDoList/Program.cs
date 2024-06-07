using System;
using System.Linq;
using ToDoCommon;
class Program
{
    static void Main()
    {

        Common myfuncions = new Common();

        List<string> todolist = myfuncions.CreateNewList();

        string UserChoice;

        do
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[S]ee all TODOs");
            Console.WriteLine("[A]dd a TODO");
            Console.WriteLine("[R]emove a TODO");
            Console.WriteLine("[E]xit");

            UserChoice = Console.ReadLine();

            switch (UserChoice)
            {
                case "S":
                case "s":
                    myfuncions.PrintSelectedOption("See all TODOs");
                    myfuncions.ShowToDos(todolist);
                    break;
                case "A":
                case "a":
                    myfuncions.AddToDoItem(todolist);
                    break;
                case "R":
                case "r":
                    myfuncions.PrintSelectedOption("Remove a TODO");
                    myfuncions.RemoveTodo(todolist);
                    break;
                case "E":
                case "e":
                    myfuncions.PrintSelectedOption("Exit");
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        } while (UserChoice != "E" && UserChoice != "e");
    }
}
