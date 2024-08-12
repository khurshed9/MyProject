    var person = new Person();

        person.FirstName = "Nabi";
        person.LastName = "Murodov";
        person.Age = 17;

        person.GetInfo();




    class Person
    {

        public string FirstName;

        public string LastName;

        public int Age;

        public void GetInfo()
        {
            Console.WriteLine($"FirstName: {FirstName}, LastNAme : {LastName}, Age: {Age}");
        }
    }



