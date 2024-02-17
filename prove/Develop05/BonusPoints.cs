using System;

public abstract class BonusPointsEarned
{
    private int _timesAcc;
    private int _bonusAcc;

    public BonusPointsEarned(int timesAcc, int bonusAcc)
    {
        _timesAcc = timesAcc;
        _bonusAcc = bonusAcc;
    }
    public int TimesAccomplished(int timesAcc)
    {
        return _timesAcc;
    }
    public int BonusAccomplished(int bonusAcc)
    {
        return _bonusAcc;
    }

    public abstract double GetBonusPoints();
}