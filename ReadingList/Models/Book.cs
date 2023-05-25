using System.ComponentModel.DataAnnotations;

namespace ReadingList.Models;

public class Book
{
    public int Id { get; set; }
    
    public string? Title { get; set; }
    
    public string? Author { get; set; }

    public string? Description { get; set; }

    [DataType(DataType.Date)] 
    public DateTime AddedDate { get; set; }
    
    public string? Note { get; set; }
}