using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DynamicBox.EventManagement;

public class WeaponShop : MonoBehaviour
{
    [SerializeField] private WeaponShopSO weapon;
    [SerializeField] private Image icon;
    [SerializeField] private Text price;

    private void Start()
    {
        icon.overrideSprite = weapon.Icon;
        price.text = weapon.Price.ToString();
    }

    public void ClickBuyButton()
    {
        EventManager.Instance.Raise(new CheckPlayerCoinsEvent(weapon));
    }
}
