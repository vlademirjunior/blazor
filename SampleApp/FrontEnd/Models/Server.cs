using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class Server
{
    public Server()
    {
        Random random = new Random();
        IsOnline = random.Next(0, 2) == 1;
    }
    
    public int Id { get; set; }
    public bool IsOnline { get; set; }
    [Required(ErrorMessage = "Please enter a valid Name")]
    [DisplayName("Server Name")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "Please enter a valid City")]
    [Display(Prompt = "Server City")]
    [DisplayFormat(NullDisplayText = "City not specified")]
    public string? City { get; set; }
}
// https://learn.microsoft.com/pt-br/dotnet/api/system.componentmodel.dataannotations?view=net-8.0
