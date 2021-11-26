using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House_Prefab : MonoBehaviour
{
    [SerializeField] private MeshFilter house;

    public MeshFilter Give_Child()
    {
        return house;
    }
}
