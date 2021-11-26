using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponShopData", menuName = "ScriptableObjects/WeaponShop", order = 4)]
public class WeaponShopSO : ScriptableObject
{
    [SerializeField] Sprite icon;
    [SerializeField] float price;
    [SerializeField] WeaponSO weapon;

    public Sprite Icon
    {
        get
        {
            return icon;
        }
    }

    public float Price
    {
        get
        {
            return price;
        }
    }

    public WeaponSO Weapon
    {
        get
        {
            return weapon;
        }
    }
}
