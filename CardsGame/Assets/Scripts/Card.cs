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
public class Card : MonoBehaviour
{ 
    private symbol symbol;
    private pictograph pictograph;
    [SerializeField]
    private List<Parameters> parameters;
    [SerializeField]
    private GameObject buildingmodel;
}
