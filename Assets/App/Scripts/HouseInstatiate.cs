using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseInstatiate : MonoBehaviour
{
    [SerializeField] List<MeshFilter> meshes = new List<MeshFilter>();
    [SerializeField] GameObject model;
    // Start is called before the first frame update
    void Start()
    {
        int index = Random.Range(0, meshes.Count);
        model.GetComponent<MeshFilter>().sharedMesh = meshes[index].sharedMesh;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
