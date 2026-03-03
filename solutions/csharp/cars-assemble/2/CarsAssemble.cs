static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        int successRate;
        
        if (speed == 0) {
            successRate = 0;
        }
        else if (speed >= 1 && speed <= 4)
        {
            successRate = 100;
        }
        else if (speed >= 5 && speed <= 8)
        {
            successRate = 90;
        }
        else if (speed == 9)
        {
            successRate = 80;
        }
        else {
            successRate = 77;
        }

        return successRate / 100.0;
    }

    public static double ProductionRatePerHour(int speed)
    {
        int car_per_hour = 221;
        
        return car_per_hour * speed * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed) => (int)ProductionRatePerHour(speed) / 60;
}