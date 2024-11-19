using System;

public class Employee
{
    public int id { get; set;}
    public string FirstName { get; set;}
    public string LastName { get; set;}

    public static bool operator ==(Employee emp1, Employee emp2)

    {
        if (ReferenceEquals( emp1, emp2)) return true;
        if (emp1 is null || emp2 is null) return false;
        return emp1.Id == emp2.Id;
    }
    public static bool Equals ( object obj)
    {
        if ( obj is employee emp)
        {
            return this.Id == emp.Id;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }






    
    }