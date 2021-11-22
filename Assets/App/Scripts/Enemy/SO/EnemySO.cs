using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Enemy", menuName ="Enemy")]
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
