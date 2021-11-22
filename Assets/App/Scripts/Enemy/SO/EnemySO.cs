using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "ScriptableObjects/Enemy", order = 2)]
public class EnemySO : ScriptableObject
{
    [SerializeField] private float _health;

    public float Health
    {
        get
        {
            return _health;
        }

        set
        {
            if ((value) > 0)
            {
                value = _health;
            }
        }
    }
}
