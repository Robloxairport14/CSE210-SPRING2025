using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Person myPerson = new Person("bubba", "bob", 53);

        Console.WriteLine(myPerson.getpersoninformation());

        PoliceMan myPoliceMan = new PoliceMan("Cooper", "Silver", 34);
        Console.WriteLine(myPoliceMan.getpersoninformation());
        Console.WriteLine(myPoliceMan.GetPoliceManInformation());

        Doctor myDoctor = new Doctor("John", "Doe", 45);
        Console.WriteLine(myDoctor.GetDoctorInformation());

        List<Person> myPeople = new List<Person>();
        myPeople.Add(myPerson);
        myPeople.Add(myPoliceMan);
        myPeople.Add(myDoctor);
        

        foreach (Person person in myPeople)
        {
            DisplayPersonInformation(person);
        }

    }

    private static void DisplayPersonInformation(Person person)
    {
        Console.WriteLine(person.getpersoninformation());
    }

}