using UnityEngine;

public class Generation_Tester : MonoBehaviour
{
    [Range(3, 50)]
    [SerializeField] private int X_Tiles=0;
    [Range(3, 50)]
    [SerializeField] private int Y_Tiles=0;

    [SerializeField] private GameObject[] Prefab_Objects;

    [SerializeField] private Mesh[] House_Mesh;

    private GameObject instance;

    private int Quarter = 0;

    private MeshFilter meshfilter;

    void Start()
    {
        transform.position = new Vector3(-X_Tiles*10 +10, 0, -Y_Tiles * 10 + 10);

        for (int i = 0; i < X_Tiles; i++)
        {
            for (int j = 0; j < Y_Tiles; j++)
            {
                if (i == 0)
                {
                    Quarter = 2;
                }

                else if (i == X_Tiles-1)
                {
                    Quarter = 4;
                }

                else if (j == 0)
                {
                    Quarter = 1;
                }

                else if (j == Y_Tiles-1)
                {
                    Quarter = 3;
                }

                if (i > 0 && i < X_Tiles-1 && j > 0 && j < Y_Tiles-1)
                {
                    Genrate(0, i, j, 0, 0);
                }

                else 
                {

                    if (i == X_Tiles - 1 && j == Y_Tiles - 1 || i == 0 && j ==0)
                    {
                        Genrate(1, i, j, Quarter, 0);
                    }

                    else if (i == 0 && j == Y_Tiles-1 || i == X_Tiles-1 && j == 0)
                    {
                        Genrate(1, i, j, Quarter, 90);
                    }

                    else 
                    {
                         instance = Instantiate(Prefab_Objects[2],
                            new Vector3(transform.position.x + 20 * i, 0, transform.position.z + 20 * j),
                            Quaternion.Euler(new Vector3(0, 90 * Quarter, 0)));

                        meshfilter = instance.GetComponent<House_Prefab>().Give_Child();

                        meshfilter.mesh = House_Mesh[Random.Range(0,House_Mesh.Length-1)];
                    }
                }
            }
        }
    }

    private void Genrate(int Object_Index ,int X_Index, int Y_Index, int Quarter, int Offset)
    {
        Instantiate(Prefab_Objects[Object_Index],
            new Vector3(transform.position.x + 20 * X_Index, 0, transform.position.z + 20 * Y_Index),
            Quaternion.Euler(new Vector3(0, 90*Quarter + Offset, 0)));
    }
}
