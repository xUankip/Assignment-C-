namespace AssignmentC;

public class SimpleProperties
{
    public string Name { get; set; }
    public bool Gender { get; set; }
    public int Age { get; set; }

    public SimpleProperties(string name, bool gender, int age)
    {
        Name = name;
        Gender = gender;
        Age = age;
    }
}