﻿namespace Domain.Models;

public class Todo
{
    public int Id { get; set; }
    public User Owner { get; set; }
    public string Title { get; set; }
    
    public bool IsCompleted { get; }

    public Todo(User owner, string title)
    {
        Owner = owner;
        Title= title;
    }
}