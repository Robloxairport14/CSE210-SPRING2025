class Doctor : Person
{
    private string _tools;

    public Doctor(string firstname, string lastname, int age) : base(firstname, lastname, age)
    {
        _tools = "stethoscope, scalpel, bandages";
    }

    public string GetDoctorInformation()
    {
        return $"tool {_tools} :: {getpersoninformation()}";
    }

}