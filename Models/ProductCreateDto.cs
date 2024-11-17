namespace FluentApiPB303.Models;

public class ProductCreateDto
{

    public string? Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
}
