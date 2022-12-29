using System;

public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
    public DateTime Date { get; set; }
    public Meetup(int month, int year)
    {
        Date = new DateTime(year, month, 1);
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        // throw new NotImplementedException("You need to implement this function.");
        while (Date.DayOfWeek != dayOfWeek)
        {
            Date = Date.AddDays(1);
        }
        switch (schedule)
        {
            case Schedule.Fourth:
                Date = Date.AddDays(21);
                break;
            case Schedule.Third:
                Date = Date.AddDays(14);
                break;
            case Schedule.Second:
                Date = Date.AddDays(7);
                break;
            case Schedule.First:
                break;
            case Schedule.Last:
                Date = new DateTime(Date.Year, Date.Month, 1);
                Date = Date.AddMonths(1);
                do
                {
                    Date = Date.AddDays(-1);
                } while (Date.DayOfWeek != dayOfWeek);
                break;
            case Schedule.Teenth:
                Date = new DateTime(Date.Year, Date.Month, 13);
                while (Date.DayOfWeek != dayOfWeek)
                {
                    Date = Date.AddDays(1);
                }
                break;
            default:
                return Date;
        }
        return Date;
    }
}