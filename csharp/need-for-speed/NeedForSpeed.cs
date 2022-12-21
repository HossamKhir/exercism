using System;

class RemoteControlCar
{
    public int Speed { get; set; }
    public int BatteryDrain { get; set; }
    private int distance;
    private int battery;
    // TODO: define the constructor for the 'RemoteControlCar' class
    public RemoteControlCar(int speed, int batteryDrain)
    {
        Speed = speed;
        BatteryDrain = batteryDrain;
        distance = 0;
        battery = 100;
    }

    public bool BatteryDrained()
    {
        // throw new NotImplementedException("Please implement the RemoteControlCar.BatteryDrained() method");
        return battery < BatteryDrain;
    }

    public int DistanceDriven()
    {
        // throw new NotImplementedException("Please implement the RemoteControlCar.DistanceDriven() method");
        return distance;
    }

    public void Drive()
    {
        // throw new NotImplementedException("Please implement the RemoteControlCar.Drive() method");
        if (battery >= BatteryDrain)
        {
            distance += Speed;
            battery -= BatteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        // throw new NotImplementedException("Please implement the (static) RemoteControlCar.Nitro() method");
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    public int Distance { get; set; }
    // TODO: define the constructor for the 'RaceTrack' class

    public RaceTrack(int distance)
    {
        Distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        // throw new NotImplementedException("Please implement the RaceTrack.TryFinishTrack() method");
        int steps = (int)Math.Ceiling((float)Distance / car.Speed);
        return (steps * car.BatteryDrain) <= 100;
    }
}
