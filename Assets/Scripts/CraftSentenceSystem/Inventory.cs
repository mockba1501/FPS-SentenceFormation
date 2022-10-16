using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour
{
    public List<InventorySlotScriptableObject> LoadInventory() 
    {
        InventorySlotScriptableObject[] inventorySlots = Resources.LoadAll<InventorySlotScriptableObject>("ScriptableObjects/Inventory/InventorySlots/");

        List<InventorySlotScriptableObject> inventory = new List<InventorySlotScriptableObject>(inventorySlots);

        return inventory;
    }
}
