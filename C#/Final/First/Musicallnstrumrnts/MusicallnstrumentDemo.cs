/*
/ Alejandro Garcia
/ module07 Assessment part B
/ This code get input from the user then send it to the class in the same folder and then output the info back here
/ Test case:
/ Drum, Alex and 2000 ----> The instrument is drum and the owner is Alex and cost about 2000
/ guitar, Alejandro and 100 -> and this instrument is guitar and the owner is Alejandro and cost about 100
/ Bass guitar, Ben and 1000 -> The instumrnt is bass guitar and the ower is ben and cost 1000
/ Drum, Ten, and 10000 ------> and this instrument is drum and the owner is ten and cost 10000
/
*/

using Musicallnstrumrnts;

MusicallInstrumentsClass person1 = new MusicallInstrumentsClass();
Console.WriteLine("What instrument is this?");
string answer1person1 = Console.ReadLine();
Console.WriteLine("What the owerns name?");
string answer2person1 = Console.ReadLine();
Console.WriteLine("How much does it cost?");
string answer3person1 = Console.ReadLine();

int answer3person1Int = Convert.ToInt32(answer3person1);

person1.SetInstrument(answer1person1);
person1.SetName(answer2person1);
person1.SetVaule(answer3person1Int);

Console.WriteLine($"The instrument is {person1.GetInstrument()} and the owner is {person1.GetName()} and cost about {person1.GetValue()}");

MusicallInstrumentsClass person2 = new MusicallInstrumentsClass();
Console.WriteLine("What instrument is this?");
string answer1person2 = Console.ReadLine();
Console.WriteLine("What the owerns name?");
string answer2person2 = Console.ReadLine();
Console.WriteLine("How much does it cost?");
string answer3person2 = Console.ReadLine();

int answer3person2Int = Convert.ToInt32(answer3person2);

person2.SetInstrument(answer1person2);
person2.SetName(answer2person2);
person2.SetVaule(answer3person2Int);

Console.WriteLine($"and this instrument is {person2.GetInstrument()} and the owner is {person2.GetName()} and cost about {person2.GetValue()}");