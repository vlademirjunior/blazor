namespace FrontEnd.Models;

public class ToDoItem
{
    public ToDoItem()
    {
        IsCompleted = false;
    }

    public int Id { get; set; }
    public string Name { get; set; } = "";
    private bool _isCompleted;
    public bool IsCompleted 
    { 
        get => _isCompleted;
        set
        {
            _isCompleted = value;
            if (value)
            {
                DateCompleted = DateTime.Now;
            }
            else
            {
                DateCompleted = DateTime.MinValue;
            }
        }
    }
    public DateTime DateCompleted { get; set; }
}
