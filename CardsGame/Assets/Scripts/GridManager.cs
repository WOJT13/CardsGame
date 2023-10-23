using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField]
    private int columnLength;
    [SerializeField]
    private int rowLength;

    [SerializeField]
    private int x_Space;
    [SerializeField]
    private int z_Space;

    [SerializeField]
    private GameObject prefab;

    [SerializeField]
    private GameObject building;

    public bool gridIsCreated;

    void Update()
    {
        if(gridIsCreated == false)
        {
            for(int i = 0; i < columnLength; i++)
            { 
                for(int j = 0; j < rowLength; j++)
                {
                    Instantiate(prefab, new Vector3(x_Space*i,0,j*z_Space), Quaternion.identity);
                    Vector3 buildingPosition = new Vector3(i * x_Space, 0, j * z_Space);
                    Instantiate(building, buildingPosition, Quaternion.identity);
                }
            }
            gridIsCreated = true;
        }
    }
}
