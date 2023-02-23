namespace TodoListCSharp;

public class TodoList
{
    private List<Task> todoListe;
    private int tasksCreated = 0;

    public TodoList()
    {
        todoListe = new List<Task>();
    }
    
    
    public int NumberOfTasks
    {
        get => tasksCreated;
        set => tasksCreated = value;
    }


    public void addTask(string description)
    {

        int id = tasksCreated;
        bool isCompleted = false;
        todoListe.Add(new Task(id,description,isCompleted));
        tasksCreated++;
    }

    public void markAsCompleted(int id)
    {
        
        Task task = todoListe.Find(task => task.Id == id);
        
        task.IsCompleted = true;
    }

    public void deleteTask(int id)
    {
      Task task = todoListe.Find(task => task.Id == id);
      todoListe.Remove(task);
    }

    public void displayList()
    {
       
        Console.WriteLine("--------------------MY TODOLIST----------------------");
        todoListe.ForEach(task => Console.WriteLine(task.ToString()));
        Console.WriteLine("-----------------------------------------------------");
    }
    
    
    
    
    
}