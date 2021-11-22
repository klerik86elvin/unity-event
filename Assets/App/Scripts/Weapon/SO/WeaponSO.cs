using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "WeaponData", menuName = "ScriptableObjects/Weapon", order = 3)]
public class WeaponSO : ScriptableObject
{
    [SerializeField] private int price;
    [SerializeField] private int demage;
    [SerializeField] private Image icon;
    [SerializeField] private GameObject prefab;

    public int Price
    {
        get
        {
            return price; 
        } 
    }
    public int Demage
    {
        get
        {
            return demage;
        }
    }
}
