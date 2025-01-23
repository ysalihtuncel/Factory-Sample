using UnityEngine;

[CreateAssetMenu(fileName = "SwordFactory", menuName = "Weapon Factory/Sword")]
public class SwordFactory : WeaponFactory
{
    IWeapon weapon;
    public override IWeapon ProvideWeapon()
    {
        if (weapon == null)
        {
            weapon = new Sword();
        }
        return weapon;
    }
}