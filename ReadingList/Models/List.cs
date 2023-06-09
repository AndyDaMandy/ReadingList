﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReadingList.Models;

public class List
{
    public int Id { get; set; }
    
    [Display(Name = "List Name")]
    public string? ListName { get; set; }
    
    [Display(Name = "Creation Date")]
    [DataType(DataType.Date)] 
    public DateTime CreationDate { get; set; }
    public string? Note { get; set; }

    public ICollection<Book> Books { get; set; }
}