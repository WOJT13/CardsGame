using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class CardsList
{
    private List<Card> cardsList = new List<Card>();

    public List<Card> GetAll()
    {
        return cardsList;
    }

    public Card GetByID(int cardID)
    {
        return cardsList.FirstOrDefault(c => c.cardID == cardID);
    }

    public void Create(Card card)
    {
        cardsList.Add(card);
    }

    public void Update(Card card)
    {
        Card cardToUpdate = cardsList.FirstOrDefault(c => c.cardID == card.cardID);
        if (cardToUpdate != null)
        {
            cardToUpdate.symbolCard = card.symbolCard;
            cardToUpdate.pictographCard = card.pictographCard;
            cardToUpdate.parametersList = card.parametersList;
            cardToUpdate.buildingModel = card.buildingModel;
        }
    }

    public void Remove(int cardID)
    {
        Card cardToDelete = cardsList.FirstOrDefault(c => c.cardID == cardID);
        if (cardToDelete != null)
        {
            cardsList.Remove(cardToDelete); 
        }
    }

    public void BuildBuilding(int building_x, int buiding_z, int index)
    {
        cardsList[index].PlacementBuilding(building_x, buiding_z);
    }
}
