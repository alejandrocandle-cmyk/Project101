using System;

namespace LandPlot;

public class LandPlotv2
{
    private string designation;
    private int LenInt;
    private int WidInt;

    public string GetDefault()
    {
        return "No arugument: plot is 100 x 100 housing";
    }

    public string GetSingleArument()
    {
        return this.designation;
    }

    public string GetThreeArument()
    {
        return this.designation;
    }

    public void SetSingleArgument(string designation)
    {

        this.designation = $"Plot is 100 x 100 designation of {designation}";

    }

    public void SetThreeArument(string designation, int LenInt, int WidInt)
    {
        this.designation = $"Plot is {LenInt} x {WidInt} designation of {designation}";
    }


}
