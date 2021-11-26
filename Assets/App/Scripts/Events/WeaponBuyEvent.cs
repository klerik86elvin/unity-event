using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DynamicBox.EventManagement;

public class WeaponBuyEvent : GameEvent
{
    public WeaponSO Weapon { get; }

    public WeaponBuyEvent(WeaponSO weapon)
    {
        Weapon = weapon;
    }
}
