class PoliceMan : Person
{
    private string _weapons;

    public PoliceMan(string firstname, string lastname, int age) : base(firstname, lastname, age)
    {
        _weapons = "gun, handcuffs, baton";
    }

    public string GetPoliceManInformation()
    {
        return $"Weapons {_weapons} :: {getpersoninformation()}";
    }

}