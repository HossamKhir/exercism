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
        int day;
        switch (schedule)
        {
            case Schedule.First:
                day = 1;
                break;
            case Schedule.Second:
                day = 8;
                break;
            case Schedule.Third:
                day = 15;
                break;
            case Schedule.Fourth:
                day = 22;
                break;
            case Schedule.Teenth:
                day = 13;
                break;
            default:
                day = DateTime.DaysInMonth(Date.Year, Date.Month) - 6;
                break;
        }
        DateTime firstDay = new DateTime(Date.Year, Date.Month, day);
        day = (dayOfWeek - firstDay.DayOfWeek + 7) % 7;
        return firstDay.AddDays(day);
    }
}