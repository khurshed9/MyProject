var person = new Person();

person.FirstName = "Nabi";
person.LastName = "Murodov";
person.Age = 17;
person.SetName("OOP");
person.GetName();
person.GetInfo();


class Person
{

    public string FirstName;

    public string LastName;

    public int Age;

    public void SetName(string name)
    {
        FirstName = name;
    }

    public string GetName()
    {
        return FirstName;
    }

        public void GetInfo()
        {
            Console.WriteLine($"FirstName: {FirstName}, LastNAme : {LastName}, Age: {Age}");
        }
    }



