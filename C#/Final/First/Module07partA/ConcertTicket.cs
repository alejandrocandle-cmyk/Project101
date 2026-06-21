// The namespace is typically the same as the project. You may change it here if necessary.
// Make sure your demo/driver program has an identical namespace statement.

namespace Module07partA;

// DO NOT EDIT ANYTHING BELOW THIS POINT

/*
 * ConcertTicket
 *
 * This class represents a purchase of concert tickets.
 * 
 */

public class ConcertTicket
{
    // Fields (instance variables)
    private string artist;
    private double price;
    private int numSeats;
    
    // Getters and Setters

    public string GetArtist()
    {
        return this.artist;
    }

    public double GetPrice()
    {
        return this.price;
    }

    public int GetNumSeats()
    {
        return this.numSeats;
    }

    public double GetTotalCost()
    {
        double cost = this.numSeats * this.price;
        return cost;
    }

    public void SetArtist(string artist)
    {
        this.artist = artist;
    }

    public void SetPrice(double price)
    {
        this.price = price;
    }

    public void SetNumSeats(int numSeats)
    {
        this.numSeats = numSeats;
    }
    
}