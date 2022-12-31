using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => new[] { 0, 2, 5, 3, 7, 8, 4 };
    // {
    //     throw new NotImplementedException("Please implement the (static) BirdCount.LastWeek() method");
    // }

    public int Today() => this.birdsPerDay[this.birdsPerDay.Length - 1];
    // {
    //     throw new NotImplementedException("Please implement the BirdCount.Today() method");
    // }

    public void IncrementTodaysCount()
    {
        // throw new NotImplementedException("Please implement the BirdCount.IncrementTodaysCount() method");
        ++this.birdsPerDay[this.birdsPerDay.Length - 1];
    }

    public bool HasDayWithoutBirds()
    {
        // throw new NotImplementedException("Please implement the BirdCount.HasDayWithoutBirds() method");
        foreach (var day in this.birdsPerDay)
        {
            if (day == 0)
            {
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        // throw new NotImplementedException("Please implement the BirdCount.CountForFirstDays() method");
        int sum = 0;
        int i = this.birdsPerDay.Length - 7;
        int end = i + numberOfDays;
        for (; i < end; ++i)
        {
            sum += this.birdsPerDay[i];
        }
        return sum;
    }

    public int BusyDays()
    {
        // throw new NotImplementedException("Please implement the BirdCount.BusyDays() method");
        int days = 0;
        foreach (var day in this.birdsPerDay)
        {
            days += (day >= 5) ? 1 : 0;
        }
        return days;
    }
}
