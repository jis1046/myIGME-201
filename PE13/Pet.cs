using System;


public class Pet
{
    
    private string name;
    private int age;
    public Pet()
    {

    }

    public Pet(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public string Name
    {
        get { return name; }

        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }


    



}
