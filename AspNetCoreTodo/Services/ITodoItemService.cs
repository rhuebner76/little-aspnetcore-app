using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Services;

public interface ITodoItemService
{
    Task<TodoItem[]> GetIncompleteItemsAsync();
    Task<bool> AddItemAsync(TodoItem newItem);
    Task<bool> MarkDoneAsync(Guid id);
}
