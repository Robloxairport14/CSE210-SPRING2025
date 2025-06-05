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

    }
}