using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftDeckSlot : CraftDeck
{
    public CraftDeckSlotScriptableObject craftDeckSlotSO;

    public void Start()
    {
        ShowCraftDeckSlotDetail();
    }

    public void ShowCraftDeckSlotDetail()
    {
        if (craftDeckSlotSO.itemInCraftDeckSlot)
        {
            Debug.Log("CraftDeckSlotID: " + craftDeckSlotSO.craftDeckSlotId + "\n" + "Item in CraftDeckSlot: " + craftDeckSlotSO.itemInCraftDeckSlot.itemId); // Just a test to show itemID of a item contended in craftDeckClot. 
        }
    }
}
