static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed is 0)
        {
            return 0;
        }
        else if (speed <= 4)
        {
            return 1;
        }
        else if (speed <= 8)
        {
            return 0.9;
        }
        else if (speed is 9)
        {
            return 0.8;
        }
        else if (speed is 10)
        {
            return 0.77;
        }
        else
        {
            return 0;
        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        int carsPerHour = 221;
        double successRate = SuccessRate(speed);
        return speed * carsPerHour * successRate;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)(ProductionRatePerHour(speed) / 60);
    }
}
