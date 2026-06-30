namespace LHPet.Models;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string CPF { get; set; }
    public string Email { get; set; }
    public string Pet { get; set; }

    public Customer(int id, string name, string cpf, string email, string pet)
    {
        Id = id;
        Name = name;
        CPF = cpf;
        Email = email;
        Pet = pet;
    }
}
