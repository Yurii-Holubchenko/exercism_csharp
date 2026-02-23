class Lasagna
{
    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int in_oven) => ExpectedMinutesInOven() - in_oven;

    public int PreparationTimeInMinutes(int layers_num) => layers_num * 2;

    public int ElapsedTimeInMinutes(int layers_num, int in_oven)
    {
        return PreparationTimeInMinutes(layers_num) + in_oven;
    }
}
