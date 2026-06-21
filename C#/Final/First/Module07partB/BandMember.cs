using System;

namespace Module07partB;

public class BandMember
{
    private string name;
    private string instruments;
    private string email;

    public string Getname()
    {
        return this.name;
    }
    public string Getinstruments()
    {
        return this.instruments;
    }
    public string Getemail()
    {
        return this.email;
    }
    public void SetName(string name)
    {
        this.name = name;
    }
    public void Setinstruments(string instruments)
    {
        this.instruments = instruments;
    }
    public void Setemail(string email)
    {
        this.email = email;
    }
}
