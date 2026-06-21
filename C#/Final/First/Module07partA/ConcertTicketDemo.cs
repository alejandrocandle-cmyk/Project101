/*
/ alejandro Garcia
/ Module07 programming assignment part A
/ This code get class info from another files and use it here then output the results that are inputed into it
/ Test Case:
/ juice ---> Juice
/ 20    ---> 40000
/ 2000
/
/ YW ----> YW
/ 12 ----> 12000
/ 1000
*/


using Module07partA;

ConcertTicket Customer1 = new ConcertTicket();

Customer1.SetArtist("Juice");
Customer1.SetPrice(20);
Customer1.SetNumSeats(2000);

Console.WriteLine(Customer1.GetArtist());
Console.WriteLine(Customer1.GetPrice());
Console.WriteLine(Customer1.GetNumSeats());
Console.WriteLine(Customer1.GetTotalCost());

ConcertTicket Customer2 = new ConcertTicket();

Customer2.SetArtist("YW");
Customer2.SetPrice(12);
Customer2.SetNumSeats(1000);

Console.WriteLine(Customer2.GetArtist());
Console.WriteLine(Customer2.GetPrice());
Console.WriteLine(Customer2.GetNumSeats());
Console.WriteLine(Customer2.GetTotalCost());

