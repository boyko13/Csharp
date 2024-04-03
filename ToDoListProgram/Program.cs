namespace ToDoList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to the 'To do list' program");
            List<string> Todolist = new List<string>();
            string option = "";

            AddToList addToList = new AddToList();
           

            while (option != "e")
            {
                Console.WriteLine("Enter 1.  to add the new task");
                Console.WriteLine("Enter 2.  to remove the task from the list");
                Console.WriteLine("Enter 3.  to view the list");
                Console.WriteLine("Enter e.  to exit the program");
                Console.WriteLine();
                string UserAnswear = Console.ReadLine();
                Console.Clear();

                if (UserAnswear == "e")
                {
                    option = "e";
                }
                else if (UserAnswear == "1")
                {
                    Console.WriteLine("Please provide a task to do here:  ");
                    Console.WriteLine();
                    addToList.ToDo = Console.ReadLine();
                    Todolist.Add(addToList.ToDo);
                    Console.Clear();


                }
                else if (UserAnswear == "2")
                {
                    if (Todolist.Count != 0)
                    {
                        
                        var num = 1;
                        foreach (string str in Todolist)
                        {

                            Console.WriteLine($"{num}.{str}");
                            Console.WriteLine();
                            num++;
                        }

                        string ToDelete = Console.ReadLine();
                        if (Todolist.Contains(ToDelete))
                        {
                            Todolist.Remove(ToDelete);
                            Console.WriteLine($"'{ToDelete}' has been deleted. ");
                        }
                        else
                        {
                            Console.WriteLine("String not found");
                        }
                        Console.Clear() ;

                    }
                    else
                    {
                        Console.WriteLine("There is no task to do in your list :(");
                    }
                }
                else if (UserAnswear == "3")
                {

                    if (Todolist.Count != 0)
                    {
                        Console.WriteLine("Your tasks to do: ");
                        Console.WriteLine();
                        var num = 1;
                        foreach (string str in Todolist)
                        {
                            
                            Console.WriteLine($"{num}.{str}");
                            Console.WriteLine();
                            num++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("There is no task to do in your list :(");
                        Console.WriteLine();
                    }
                    
                    
                }
                else
                {
                    Console.WriteLine("Please, input the correct answear only ");
                }

            }
            Console.Clear();
            Console.WriteLine("Thank you have nice day!");
        }
    }
}
