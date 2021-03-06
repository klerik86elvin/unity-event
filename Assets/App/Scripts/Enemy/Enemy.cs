using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public EnemySO data;
    private float _health;


    [SerializeField] Image health;

    private void Start()
    {
        _health = data.Health;
    }

    private void FixedUpdate()
    {
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
    
}
