using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "WeaponData", menuName = "ScriptableObjects/Weapon", order = 3)]
public class WeaponSO : ScriptableObject
{
    [SerializeField] private int demage;
    [SerializeField] private GameObject prefab;

    public int Demage
    {
        get
        {
            return demage;
        }
    }

    public GameObject Prefab
    {
        get
        {
            return prefab;
        }
    }
}
