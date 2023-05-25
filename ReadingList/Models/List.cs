using System.ComponentModel.DataAnnotations;

namespace ReadingList.Models;

public class List
{
    public int Id { get; set; }
    public string? ListName { get; set; }
    [DataType(DataType.Date)] 
    public DateTime CreationDate { get; set; }
    public string? Note { get; set; }
}