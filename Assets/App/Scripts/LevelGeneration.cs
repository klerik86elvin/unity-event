using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneration : MonoBehaviour
{
    public List<GameObject> gameObjects = new List<GameObject>();

    [SerializeField] GameObject housePrefab;


    public int col;
    public int row;
    // Start is called before the first frame update
    void Start()
    {
        string a = "";

        for(int i = 0; i< col; i++)
        {
            for (int j = 0; j < row; j++)
            {
                GameObject gameObject = Instantiate(housePrefab, new Vector3(j * 20, 0, i * 20), Quaternion.identity);
                /*if(isLeftSide(i, j))
                {
                    gameObject.transform.eulerAngles = new Vector3(0, 90, 0);
                }*/

            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private bool IsTurn(int i, int j)
    {
        return (i == 0 && j == 0) ||
            (i == 0 && j == row -1) ||
            (i == col - 1 && j == 0) ||
            (i == col - 1 && j == row - 1);
    }

    bool IsHouse(int i, int j)
    {
        return (i == 0 && (j != 0 && j != row - 1)) ||
           ((i > 0 && i < col - 1) && (j == 0 || j == row - 1)) ||
           ((i == col - 1) && (j != 0 && j != row - 1));
    }

    bool IsLeftSide(int i, int j)
    {
        return i > 0 && i < col - 1;
    }
}
