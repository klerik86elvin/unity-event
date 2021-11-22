using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField]private PlayerSO data;
    [SerializeField] private Image health;
    private float _health;
    // Start is called before the first frame update
    void Start()
    {
        _health = data.Health;
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
