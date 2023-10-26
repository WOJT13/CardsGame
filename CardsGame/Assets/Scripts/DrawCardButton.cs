using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCardButton : MonoBehaviour
{
    //public DataManager DataManager;
    public int building_x;
    public int building_y;
    public void Click()
    {
        Debug.Log(DataManager.Instance == null);
        Debug.Log(DataManager.Instance.cardList == null);
        //DataManager.Instance.cardList.BuildBuilding(building_x, building_y, 0);
        building_x = Random.Range(0, 2);
        building_y = Random.Range(0, 2); 
        DataManager.Instance.cardList.BuildBuilding(building_x, building_y, 0);
    }
}
