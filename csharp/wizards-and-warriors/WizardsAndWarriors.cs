using System;

abstract class Character
{
    protected string CharacterType { get; set; }
    protected bool vulnerable = false;

    protected Character(string characterType)
    {
        // throw new NotImplementedException("Please implement the Character() constructor");
        this.CharacterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => this.vulnerable;
    // {
    //     throw new NotImplementedException("Please implement the Character.Vulnerable() method");
    // }

    public override string ToString() => $"Character is a {this.CharacterType}";
    // {
    //     throw new NotImplementedException("Please implement the Character.ToString() method");
    // }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target) => (target.Vulnerable() ? 10 : 6);
    // {
    //     throw new NotImplementedException("Please implement the Warrior.DamagePoints() method");
    // }
}

class Wizard : Character
{
    public Wizard() : base("Wizard")
    {
        this.vulnerable = true;
    }

    public override int DamagePoints(Character target) => ((this.vulnerable) ? 3 : 12);
    // {
    //     throw new NotImplementedException("Please implement the Wizard.DamagePoints() method");
    // }

    public void PrepareSpell()
    {
        // throw new NotImplementedException("Please implement the Wizard.PrepareSpell() method");
        this.vulnerable = false;
    }
}
