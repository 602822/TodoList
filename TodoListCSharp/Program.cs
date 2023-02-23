

using TodoListCSharp;

TodoList todoList = new TodoList();


int action = 0;


while (action != 4)
{

  Console.WriteLine("1: Add Task");
  Console.WriteLine("2: Delete Task");
  Console.WriteLine("3: Mark Task As Finished");
  Console.WriteLine("4: Quit");

  Console.Write("Type your action here: ");
   action = Convert.ToInt32(Console.ReadLine());



  switch (action)
  {

    case 1:
    {
      Console.WriteLine("Enter task here: ");
      String description = Console.ReadLine();
      todoList.addTask(description);
      todoList.displayList();

    }
      break;

    case 2:
    {
      Console.WriteLine("What task do you want to delete? Enter the id here: ");
      int id = Convert.ToInt32(Console.ReadLine());
      todoList.deleteTask(id);
      todoList.displayList();

    }
      break;

    case 3:
    {
      Console.WriteLine("What task have you finished? Enter the id here: ");
      int id = Convert.ToInt32(Console.ReadLine());
      todoList.markAsCompleted(id);
      todoList.displayList();

    }
      break;

    case 4:
    {
      break;
    }
      break;
  }
}

