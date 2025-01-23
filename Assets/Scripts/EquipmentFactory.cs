using UnityEngine;

[CreateAssetMenu(fileName = "EquipmentFactory", menuName = "Equipment Factory")]
public class EquipmentFactory : ScriptableObject
{
    public WeaponFactory weaponFactory;
    public ShieldFactory shieldFactory;

    public IWeapon ProvideWeapon()
    {
        return weaponFactory != null ? weaponFactory.ProvideWeapon() : IWeapon.CreateDefault();
    }

    public IShield ProvideShield()
    {
        return shieldFactory != null ? shieldFactory.ProvideShield() : IShield.CreateDefault();
    }
}
