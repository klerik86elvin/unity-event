using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "ScriptableObjects/Player", order = 1)]
public class PlayerSO : ScriptableObject
{
    [SerializeField] private float health;

    public float Health
    {
        get
        {
            return health;
        }
    }
}
