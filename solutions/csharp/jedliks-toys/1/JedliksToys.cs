class RemoteControlCar
{
    private static RemoteControlCar _instance;
    private int _drive = 0;
    
    public static RemoteControlCar Buy()
    {
        _instance = new RemoteControlCar();
        return _instance;
    }

    public string DistanceDisplay()
    {
        int distance = _drive * 20;
        return $"Driven {distance} meters";
    }

    public string BatteryDisplay()
    {
        int percentage = 100 - _drive;
        string batteryState = percentage > 0 ? $"Battery at {percentage}%" : "Battery empty";
        return batteryState;
    }

    public void Drive()
    {
        Console.WriteLine(_drive);
        if (_drive < 100)
        {
            ++_drive;
        }
    }
}
