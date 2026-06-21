using System;

namespace Final;

public class FinalClass
{
    private string FavoriteFood;

    private string place;
    private int cost;

    public string GetFavoriteFood()
    {
        return this.FavoriteFood;
    }

    public string Getplace()
    {
        return this.place;
    }

    public int Getcost()
    {
        return this.cost; 
    }

    public void SetFavoriteFood(string FavoriteFood)
    {
        this.FavoriteFood = FavoriteFood;
    }

    public void SetPlace(string place)
    {
        this.place = place;
    }

    public void SetCost(int cost)
    {
        this.cost = cost;
    }
}

