

namespace ToDoList
{
    class Program
    {
        static void Main()
        {

            List<string> todolist = CreateNewList();

            string UserChoice;

            do
            {
                Console.WriteLine("Hello!");
                Console.WriteLine("");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("[S]ee all TODOs");
                Console.WriteLine("[A]dd a TODO");
                Console.WriteLine("[R]emove a TODO");
                Console.WriteLine("[E]xit");

                UserChoice = GetUserInput();

                switch (UserChoice)
                {
                    case "S":
                    case "s":
                        PrintSelectedOption("See all TODOs");
                        ShowToDos(todolist);
                        break;
                    case "A":
                    case "a":
                        AddToDoItem(todolist);
                        break;
                    case "R":
                    case "r":
                        PrintSelectedOption("Remove a TODO");
                        RemoveTodo(todolist);
                        break;
                    case "E":
                    case "e":
                        PrintSelectedOption("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            } while (UserChoice != "E" && UserChoice != "e");
        }

        static void PrintSelectedOption(string selectedOption)
        {
            Console.WriteLine("Selected option: " + selectedOption);
        }


        public static List<string> CreateNewList()
        {
            return new List<string>();
        }

        static void AddToDoItem(List<string> myList)
        {
            PrintSelectedOption("Add a Todo");
            string newTodo = null;
            while (string.IsNullOrEmpty(newTodo) || myList.Contains(newTodo))
            {
                Console.WriteLine("Enter a Todo");
                newTodo = Console.ReadLine();
                if (string.IsNullOrEmpty(newTodo))
                {
                    Console.WriteLine("That was empty, enter a Todo!");
                }

                else if (myList.Contains(newTodo))
                {
                    Console.WriteLine("Already exists.");
                }
            }
            myList.Add(newTodo);
        }

        static void ShowToDos(List<string> myList)
        {
            foreach (var todo in myList.Select((value, index) => new { value, index }))
            {
                Console.WriteLine($"{todo.index}: {todo.value}");
            }

        }

        static void RemoveTodo(List<string> myList)
        {
            Console.WriteLine("Remove by writing index number.");
            ShowToDos(myList);

            int removeVar = -1;
            while (removeVar < 0 || removeVar >= myList.Count)
            {
                Console.WriteLine("Remove by writing index number.");
                bool parse = int.TryParse(Console.ReadLine(), out removeVar);

                if (parse == false)
                {
                    Console.WriteLine("That's not a number.");
                }
                else if (removeVar < 0 || removeVar >= myList.Count)
                {
                    Console.WriteLine("Out of range.");
                }
            }
            myList.RemoveAt(removeVar);
            Console.WriteLine("Item removed successfully.");
            ShowToDos(myList);

        }

        static string GetUserInput()
        {
            string userInput = "";
            while (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Enter a ToDo");
                userInput = Console.ReadLine();
                if (string.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine("Enter something");

                }
            }
            return userInput;


        }

    }


}










