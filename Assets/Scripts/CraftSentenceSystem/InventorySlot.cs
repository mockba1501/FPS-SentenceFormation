using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot : Inventory
{
    public InventorySlotScriptableObject inventorySlotSO;

    public void Start()
    {
        ShowInventorySlotDetail();
    }

    public void ShowInventorySlotDetail()
    {
        if (inventorySlotSO.itemInInventorySlot) 
        {
            Debug.Log(inventorySlotSO.itemInInventorySlot.itemId); // Just a test to show itemID of a item contended in inventory slots. 
        }
    }
}
