﻿using Console = System.Console;

var person = new Person();

person.FirstName = "Nabi";
person.LastName = "Murodov";
person.Age = 17;
person.SetName("OOP");
person.GetName();
person.GetInfo();
person.CheckAge();

var person2 = new Person();

person2.FirstName = "Rob";
person2.LastName = "Paos";
person2.Age = 32;
person2.SetName("bdj");
person2.GetName();
person2.GetInfo();
person2.CheckAge();


class Person
{

    public string FirstName;

    public string LastName;

    public int Age;

    public void CheckAge()
    {
        if (Age > 18)
        {
            Console.WriteLine("You are not kid anymore");
        }
        else
        {
            Console.WriteLine("You are kid");
        }
        
    }

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



