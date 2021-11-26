using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;
using DynamicBox.EventManagement;


public class Player : MonoBehaviour
{
    [SerializeField] private PlayerSO data;
    [SerializeField] private Image health;
    private float _health;
    [SerializeField] CinemachineFreeLook cinemachine;
    // Start is called before the first frame update


    public WeaponSO Weapon
    {
        get
        {
            return data.Weapon;
        }
        
    }
    private void OnEnable()
    {
        EventManager.Instance.AddListener<CheckPlayerCoinsEvent>(checkCoinsHanler);
    }

    private void OnDisable()
    {
        EventManager.Instance.RemoveListener<CheckPlayerCoinsEvent>(checkCoinsHanler);
    }
    void Start()
    {
        _health = data.Health;
    }

    private void Update()
    {
        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, cinemachine.m_XAxis.Value, transform.eulerAngles.z);
    }
    public void TakeDemage(float demage)
    {
        if (_health - demage < 0)
        {
            _health = 0;
        }
        else _health -= demage;
        health.fillAmount = Mathf.Clamp(_health / data.Health, 0, 1);
    }

    private void checkCoinsHanler(CheckPlayerCoinsEvent coinsEvent)
    {
        if(data.Coins > coinsEvent.Weapon.Price)
        {
            data.Weapon = coinsEvent.Weapon.Weapon;
            EventManager.Instance.Raise(new WeaponBuyEvent(data.Weapon));
        }
        else
            print("netu");

    }

}
