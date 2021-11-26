using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DynamicBox.EventManagement;

public class CheckPlayerCoinsEvent : GameEvent
{
    public readonly WeaponShopSO Weapon;

    public CheckPlayerCoinsEvent(WeaponShopSO weapon)
    {
        Weapon = weapon;
    }
}
