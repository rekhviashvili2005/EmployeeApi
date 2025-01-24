namespace API111.Entities;

public class Employee
{
    public Guid Id { get; set; }    

    public required string Name { get; set; }   

    public required string Email { get; set; }  

    public required string PhoneNumber  { get; set; }

    public float Salary { get; set; } 

}
