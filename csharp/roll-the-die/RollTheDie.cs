using System;

public class Player
{

    public int RollDie() => ((new Random()).Next() % 17) + 1;
    // {
    //     throw new NotImplementedException("Please implement the Player.RollDie() method");
    // }

    public double GenerateSpellStrength() => (new Random()).NextDouble() * 100.0;
    // {
    //     throw new NotImplementedException("Please implement the Player.GenerateSpellStrength() method");
    // }
}
