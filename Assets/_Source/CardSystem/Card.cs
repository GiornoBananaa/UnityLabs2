using UnityEngine;

public abstract class Card
{
    public abstract string Name { get; }
    public abstract Sprite Icon { get; }
    public abstract string Description { get; }
    public abstract void Use();
}

public interface IMeleeFighter
{
    
}

public interface IArcher
{
    
}

public interface ISiegeWeapon
{
    
}

public interface ISpecialAbilityUser
{
    void UseSpecialAbility();
}

public interface IUltimateAbilityUser
{
    void UseUltimateAbility();
}

public interface IPowerOwner
{
    int Power { get; }
    void UsePower();
}

public interface IWeatherCard
{
    void UseWeatherEffect();
}