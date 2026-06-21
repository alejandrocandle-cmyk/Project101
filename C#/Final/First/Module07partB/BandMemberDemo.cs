/*
/ Alejandro Garcia
/ programming asignment 07 part B
/ This code test info from a class file in the same file and sends info and get info out
/ Test case:
/ Ben ------------> BEn
/ Drummer --------> Drummer
/ Bem@gmail.com --> Ben@gmail.com
/
*/

namespace Module07partB;

class Program
{
    static void Main(string[] args)
    {
        BandMember member1 = new BandMember();
        member1.SetName("Ben");
        member1.Setinstruments("Drummer");
        member1.Setemail("Ben@gmail.com");
        Console.WriteLine(member1.Getname());
        Console.WriteLine(member1.Getemail());
        Console.WriteLine(member1.Getinstruments());
        BandMember member2 = new BandMember();
        member2.SetName("Alex");
        member2.Setinstruments("Bass");
        member2.Setemail("Alex@gmail.com");
        Console.WriteLine(member2.Getname());
        Console.WriteLine(member2.Getemail());
        Console.WriteLine(member2.Getinstruments());
        BandMember member3 = new BandMember();
        member3.SetName("Rene");
        member3.Setinstruments("Singer");
        member3.Setemail("Rene@gmail.com");
        Console.WriteLine(member3.Getname());
        Console.WriteLine(member3.Getemail());
        Console.WriteLine(member3.Getinstruments());

    }
}
