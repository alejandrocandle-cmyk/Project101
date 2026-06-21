/*
/ Alejandro Garcia
/ Coding Assessment Part A
/ This code get the info from another file but at the same time use the folder and the class is can use one string or 2 int but then doesn't 
/ need to use them
/ test case:
/ Backyear ----> Plot is 100 x 100 designation of backyard
/ nothing -----> No arugument: plot is 100 x 100 housing
/ Frontyerd, 54, 21 -> Plot is 54 x 21 designation of Fortyard
/
*/

using LandPlot;

LandPlotv2 person1 = new LandPlotv2();

person1.SetSingleArgument("backyard");

Console.WriteLine(person1.GetSingleArument());

LandPlotv2 Person2 = new LandPlotv2();
Person2.SetThreeArument("Frontyard", 54, 21);

Console.WriteLine(Person2.GetThreeArument());

LandPlotv2 person3 = new LandPlotv2();

Console.WriteLine(person3.GetDefault());
