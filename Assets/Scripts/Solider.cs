using UnityEngine;

public class Solider : MonoBehaviour
{
    [SerializeField] EquipmentFactory equipmentFactory;

    void Start()
    {
        Attack();
        Defend();
    }

    public void Attack() => equipmentFactory.ProvideWeapon().Attack();
    public void Defend() => equipmentFactory.ProvideShield().Defend();
}