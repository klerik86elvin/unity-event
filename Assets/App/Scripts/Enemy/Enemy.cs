using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public EnemySO enemyData;
    private float _health;


    [SerializeField] Image health;

    private void Start()
    {
        _health = enemyData.Health;
    }

    public void TakeDemage(float demage)
    {
        if (_health - demage < 0)
        {
            _health = 0;
        }
        else _health -= demage;
        health.fillAmount = Mathf.Clamp(_health/ enemyData.Health, 0, 1);
    }
    
}
