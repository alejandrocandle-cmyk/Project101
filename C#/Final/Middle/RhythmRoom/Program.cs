/*
/ Alejandro Garcia
/ Module10 programming partice B
/
/
/ iteration part 1 
/ Console.WriteLine("write ten names");
/ Console.ReadLine();
/ Console.ReadLine();
/ Console.ReadLine();
/ Console.ReadLine();
/ Console.ReadLine();
/ Console.ReadLine();
/ Console.ReadLine();
/ Console.ReadLine();
/ Console.ReadLine();
/ Console.ReadLine();
*/
/*
/ iteration part 2
/ console.writeLine("How many people are coming?")
/ people = console.ReadLine();
/ for (int i = 0; i < people.length; i++)
/ {
/    console.ReadLine();
/ }
/
*/

Console.WriteLine("Write ten names");

for (int i = 0; i < 10; i++)
{
    Console.ReadLine();
}

Console.WriteLine("How many people are coming?");
string people = Console.ReadLine();
int peopleint = Convert.ToInt32(people);

int sum = -1;

string[] part = new string[peopleint];
Console.WriteLine("Put the people names");
for(int i = 0; i < peopleint; i++)
{
    sum += 1;
    Console.WriteLine($"Enter name {sum}");
    part[sum] = Console.ReadLine();
}

int sumv2 = 0;
Console.WriteLine("This is all the people that are coming");
for (int i = 0; i < part.Length; i++)
{
    sumv2 += 1;
    Console.WriteLine($"{sumv2}: {part[i]}");
}