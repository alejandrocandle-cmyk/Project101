/*
/ Alejandro Garcia 
/ Module10 practice A
/ this code call on a static then check how much the book fee is then returns a result
/ Test case:
/ Dj, 250 ---> 50
/ Band, 350 -> 52.5
/ OpenMic, 350 --> 35
/ Band, 500 ----> 75
/ DJ, 200 ---> 50
*/

namespace MessyCode;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"The book fee: {CalculateBookingFee("DJ", 200)}");

        static double CalculateBookingFee(string actType, int att)
        {
            double fee = 0;

            if (actType == "DJ")
            {
                if (att > 200)
                {
                    fee = att * 0.20;
                }
                else
                {
                    if (att > 100)
                    {
                        fee = att * 0.25;
                    }
                    else
                    {
                        fee = att * 0.30;
                    }

                }
            }
            else if (actType == "Band")
            {

                if (att > 200)
                {
                    fee = att * 0.15;
                }
                else
                {
                    if (att > 100)
                    {
                        fee = att * 0.20;
                    }
                    else
                    {
                        fee = att * 0.28;
                    }
                }
            }

            else if (actType == "OpenMic")
            {

                if (att > 150)
                {
                    fee = att * 0.10;
                }
                else
                {
                    if (att > 50)
                    {
                        fee = att * 0.12;
                    }
                    else
                    {
                        fee = att * 0.15;
                    }
                }
            }

            else
            {
                fee = att * 0.50; // mystery acts are expensive!
            }
            return fee;

        }
    }
}

// this was a lot of if and else statment so I took some away to make it easy on the eyes and change the f to fee to better understand what it is