using System;

class RemoteControlCar
{
    public int Distance { set; get; }
    public int Battery { set; get; }

    public RemoteControlCar()
    {
        Distance = 0;
        Battery = 100;
    }

    public static RemoteControlCar Buy()
    {
        // throw new NotImplementedException("Please implement the (static) RemoteControlCar.Buy() method");
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        // throw new NotImplementedException("Please implement the RemoteControlCar.DistanceDisplay() method");
        return $"Driven {Distance} meters";
    }

    public string BatteryDisplay()
    {
        // throw new NotImplementedException("Please implement the RemoteControlCar.BatteryDisplay() method");
        if (Battery <= 0)
        {
            return "Battery empty";
        }
        return $"Battery at {Battery}%";
    }

    public void Drive()
    {
        // throw new NotImplementedException("Please implement the RemoteControlCar.Drive() method");
        if (Battery > 0)
        {
            Distance += 20;
            Battery -= 1;
        }
    }
}
