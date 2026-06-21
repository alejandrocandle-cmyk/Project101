using System;

namespace Musicallnstrumrnts;

public class MusicallInstrumentsClass
{
    private string instrument;
    private string name;
    private int vaule;

    public string GetInstrument()
    {
        return this.instrument;
    }

    public string GetName()
    {
        return this.name;
    }

    public int GetValue()
    {
        return this.vaule; 
    }

    public void SetInstrument(string instrument)
    {
        this.instrument = instrument;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetVaule(int vaule)
    {
        this.vaule = vaule;
    }
}
