namespace TodoListCSharp;

public class Task
{
    private int id;
    private String description;
    private bool isCompleted;


    public Task(int id, string description, bool isCompleted)
    {
        this.id = id;
        this.description = description;
        this.isCompleted = isCompleted;
    }


    public int Id
    {
        get => id;
        set => id = value;
    }

    public string Description
    {
        get => description;
        set => description = string.IsNullOrWhiteSpace(value) ? throw new ArgumentNullException(nameof(value)) : value;
    }

    public bool IsCompleted
    {
        get => isCompleted;
        set => isCompleted = value;
        
    }

    public override string ToString()
    {
        return $" Task {id}: {description}, Ferdig = {isCompleted}";
    }
    
    
    
}