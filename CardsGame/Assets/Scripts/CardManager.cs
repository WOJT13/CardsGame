using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public CardsList cardsList = new CardsList();
    public GameObject building;

    void Start()
    {
        Card KingCard = new Card
        {
            cardID = 1,
            symbolCard = symbol.Pik,
            pictographCard = pictograph.Krol,
            parametersList = new List<Parameters>()
            
        };
        KingCard.parametersList.Add(new Parameters() { category = "a", points = 2 });
        KingCard.buildingModel = building;
        cardsList.Create(KingCard);
        DataManager.Instance.cardList = cardsList;
        Debug.Log(DataManager.Instance.cardList == null) ;
    }

}
