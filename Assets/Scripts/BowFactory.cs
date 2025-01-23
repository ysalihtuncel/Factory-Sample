using UnityEngine;

[CreateAssetMenu(fileName = "BowFactory", menuName = "Weapon Factory/Bow")]
public class BowFactory : WeaponFactory
{
    IWeapon weapon;
    public override IWeapon ProvideWeapon()
    {
        if (weapon == null)
        {
            weapon = new Bow();
        }
        return weapon;
    }
}