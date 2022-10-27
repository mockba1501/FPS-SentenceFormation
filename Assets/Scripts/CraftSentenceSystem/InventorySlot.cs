using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventorySlot : Inventory
{
    public GameObject inventorySlot;
    public TMPro.TMP_Text wordInItem;
    public InventorySlotScriptableObject inventorySlotSO;

    public void Start()
    {
        ShowInventorySlotDetail();
    }

    public void ShowInventorySlotDetail()
    {
        if (inventorySlotSO.itemInInventorySlot) 
        {
            inventorySlot.GetComponent<Image>().sprite = inventorySlotSO.itemInInventorySlot.itemSprite;
            wordInItem.text = inventorySlotSO.itemInInventorySlot.word;

            Debug.Log("InventorySlotID: " + inventorySlotSO.inventorySlotId  + "\n" + "Item in InventorySlot: " + inventorySlotSO.itemInInventorySlot.itemId); // Just a test to show itemID of a item contended in inventory slot. 
        }
    }
}
