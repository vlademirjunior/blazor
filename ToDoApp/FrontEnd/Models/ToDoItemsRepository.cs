namespace FrontEnd.Models;

public static class ToDoItemsRepository
{
    private static List<ToDoItem> items = new List<ToDoItem>()
    {
        new ToDoItem { Id = 1, Name = "Buy milk", IsCompleted = false, DateCompleted = DateTime.MinValue },
        new ToDoItem { Id = 2, Name = "Clean the house", IsCompleted = true, DateCompleted = DateTime.Now },
        new ToDoItem { Id = 3, Name = "Go to the gym", IsCompleted = false, DateCompleted = DateTime.MinValue },
        new ToDoItem { Id = 4, Name = "Pick up the kids", IsCompleted = false},
    };

    public static List<ToDoItem> GetItems()
    {
        var SortItems = items.OrderBy(i => i.IsCompleted).ThenByDescending(i => i.Id).ToList();
        return SortItems;
    }

    public static ToDoItem? GetItem(int id) => items.FirstOrDefault(i => i.Id == id);

    public static void AddItem(ToDoItem item)
    {
        if (items.Count == 0)
        {
            item.Id = 1;
        }
        else
        {
            item.Id = items.Max(i => i.Id) + 1;
            items.Add(item);
        }
    }

    public static void UpdateItem(ToDoItem item)
    {
        var existingItem = items.FirstOrDefault(i => i.Id == item.Id);
        if (existingItem != null)
        {
            existingItem.Name = item.Name;
            existingItem.IsCompleted = item.IsCompleted;
            existingItem.DateCompleted = item.DateCompleted;
        }
    }

    public static void DeleteItem(int id)
    {
        var existingItem = items.FirstOrDefault(i => i.Id == id);
        if (existingItem != null)
        {
            items.Remove(existingItem);
        }
    }

    public static void SearchItems(string searchTerm)
    {
        items = items.Where(i => i.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public static void ResetItems()
    {
        items = new List<ToDoItem>()
        {
            new ToDoItem { Id = 1, Name = "Buy milk", IsCompleted = false, DateCompleted = DateTime.MinValue },
            new ToDoItem { Id = 2, Name = "Clean the house", IsCompleted = true, DateCompleted = DateTime.Now },
            new ToDoItem { Id = 3, Name = "Go to the gym", IsCompleted = false, DateCompleted = DateTime.MinValue }
        };
    }

    public static void CompleteItem(int id)
    {
        var existingItem = items.FirstOrDefault(i => i.Id == id);
        if (existingItem != null)
        {
            existingItem.IsCompleted = true;
            existingItem.DateCompleted = DateTime.Now;
        }
    }

    public static void UncompleteItem(int id)
    {
        var existingItem = items.FirstOrDefault(i => i.Id == id);
        if (existingItem != null)
        {
            existingItem.IsCompleted = false;
            existingItem.DateCompleted = DateTime.MinValue;
        }
    }

    public static void ToggleItem(int id)
    {
        var existingItem = items.FirstOrDefault(i => i.Id == id);
        if (existingItem != null)
        {
            existingItem.IsCompleted = !existingItem.IsCompleted;
            existingItem.DateCompleted = existingItem.IsCompleted ? DateTime.Now : DateTime.MinValue;
        }
    }

    public static void SortItems()
    {
        items = items.OrderBy(i => i.Name).ToList();
    }
}
