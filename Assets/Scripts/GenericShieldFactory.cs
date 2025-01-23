using UnityEngine;

[CreateAssetMenu(fileName = "GenericShieldFactory", menuName = "Shield Factory/Generic")]
public class GenericShieldFactory : ShieldFactory
{
    IShield shield;
    public override IShield ProvideShield()
    {
        if (shield == null)
        {
            shield = new Shield();
        }
        return shield;
    }
}