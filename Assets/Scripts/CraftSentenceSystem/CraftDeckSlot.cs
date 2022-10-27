using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CraftDeckSlot : CraftDeck
{
    public GameObject craftDeckSlot;
    public TMPro.TMP_Text wordInItem;
    public CraftDeckSlotScriptableObject craftDeckSlotSO;

    public void Start()
    {
        ShowCraftDeckSlotDetail();
    }

    public void ShowCraftDeckSlotDetail()
    {
        if (craftDeckSlotSO.itemInCraftDeckSlot)
        {
            craftDeckSlot.GetComponent<Image>().sprite = craftDeckSlotSO.itemInCraftDeckSlot.itemSprite;
            wordInItem.text = craftDeckSlotSO.itemInCraftDeckSlot.word;
            Debug.Log("CraftDeckSlotID: " + craftDeckSlotSO.craftDeckSlotId + "\n" + "Item in CraftDeckSlot: " + craftDeckSlotSO.itemInCraftDeckSlot.itemId); // Just a test to show itemID of a item contended in craftDeckClot. 
        }
    }
}
