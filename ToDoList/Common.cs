using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ToDoCommon
{
    internal class Common
    {
        public void PrintSelectedOption(string selectedOption)
        {
            Console.WriteLine("Selected option: " + selectedOption);
        }

        public List<string> CreateNewList()
        {
            return new List<string>();
        }

        public void AddToDoItem(List<string> myList)
        {
            PrintSelectedOption("Add a Todo");
            string newTodo = null;
            while (string.IsNullOrEmpty(newTodo))
            {
                Console.WriteLine("Enter a Todo");
                newTodo = Console.ReadLine();
                if (string.IsNullOrEmpty(newTodo))
                {
                    Console.WriteLine("That was empty, enter a Todo!");
                }
            }
            myList.Add(newTodo);

        }

        public void ShowToDos(List<string> myList)
        {
            foreach (var todo in myList.Select((value, index) => new { value, index }))
            {
                Console.WriteLine($"{todo.index}: {todo.value}");
            }

        }

        public void RemoveTodo(List<string> myList)
        {
            Console.WriteLine("Remove by writing index number.");
            ShowToDos(myList);

            int removeVar = -1;
            while (removeVar < 0 || removeVar >= myList.Count)
            {
                Console.WriteLine("Remove by writing index number.");
                bool parse = int.TryParse(Console.ReadLine(), out removeVar);

                if (!parse)
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

    }


}
