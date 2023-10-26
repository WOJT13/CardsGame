using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public enum symbol
{
    Pik,
    Kier,
    Trefl,
    Karo
}

public enum pictograph
{
    As,
    Krol,
    Dama,
    Walet,
    n10,
    n9,
    n8,
    n7,
    n6,
    n5,
    n4,
    n3,
    n2
}
[System.Serializable]
public class Card : MonoBehaviour
{
    public int cardID;
    public symbol symbolCard;
    public pictograph pictographCard;

    public List<Parameters> parametersList;
    public GameObject buildingModel;

    public GridManager grid;
    //public int building_x;
    //public int building_z;

    public void PlacementBuilding(int building_x, int building_z)
    {
        GridManager g = grid;
        Vector3 buildingPosition = new Vector3(building_x * g.x_Space, 0, building_z * g.z_Space);
        Instantiate(buildingModel, buildingPosition, Quaternion.identity);
    }
}


