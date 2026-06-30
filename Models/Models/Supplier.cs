namespace LHPet.Models;

public class Supplier
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string CNPJ { get; set; }
    public string Email { get; set; }

    public Supplier(int id, string name, string cnpj, string email)
    {
        Id = id;
        Name = name;
        CNPJ = cnpj;
        Email = email;
    }
}
