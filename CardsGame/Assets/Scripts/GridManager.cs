using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField]
    private int columnLength;
    [SerializeField]
    private int rowLength;

    
    public int x_Space;
   
    public int z_Space;

    [SerializeField]
    private GameObject prefab;

    [SerializeField]
    private GameObject building;

    public bool gridIsCreated;



    void Start()
    {
        if(gridIsCreated == false)
        {
            for(int i = 0; i < columnLength; i++)
            { 
                for(int j = 0; j < rowLength; j++)
                {
                    Instantiate(prefab, new Vector3(x_Space*i,0,j*z_Space), Quaternion.identity);
                    //Vector3 buildingPosition = new Vector3(1 * x_Space, 0, 0 * z_Space);
                    //Instantiate(building, buildingPosition, Quaternion.identity);
                }
            }
            gridIsCreated = true;
        }
    }
}
