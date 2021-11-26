using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "ScriptableObjects/Player", order = 1)]
public class PlayerSO : ScriptableObject
{
    [SerializeField] private float health;
    [SerializeField] private float coins;
    [SerializeField] private WeaponSO weapon;
 
    public WeaponSO Weapon
    {
        get
        {
            return weapon;
        }
        set
        {
            weapon = value;
        }
    }
    public float Health
    {
        get
        {
            return health;
        }
    }

    public float Coins
    {
        get
        {
            return coins;
        }
    }
}
