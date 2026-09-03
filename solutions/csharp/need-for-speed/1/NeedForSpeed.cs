class RemoteControlCar
{
    private int _batteryDrain;
    private int _speed;
    private int _distance = 0;
    private int _battery = 100;
    // TODO: define the constructor for the 'RemoteControlCar' class
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this._batteryDrain = batteryDrain;
        this._speed = speed;
    }

    public bool BatteryDrained()
    {
        return this._battery - this._batteryDrain < 0;
    }

    public int DistanceDriven()
    {
        return this._distance * this._speed;
    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
            this._distance++;
            this._battery -= this._batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private int _distance;
    // TODO: define the constructor for the 'RaceTrack' class

    public RaceTrack(int distance)
    {
        this._distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (car.DistanceDriven() < this._distance && !car.BatteryDrained())
        {
            car.Drive();
            Console.WriteLine(car.DistanceDriven());
        }

        return car.DistanceDriven() >= this._distance;
    }
}
