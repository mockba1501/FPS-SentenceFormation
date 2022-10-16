using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InventorySlot", menuName = "Scriptableobjects/Inventory/InventorySlot", order = 1)]
public class InventorySlotScriptableObject : ScriptableObject
{
    public int inventorySlotId;
    public ItemScriptableObject itemInInventorySlot;
    public bool isOccupied; // if item is in this slot, then true. if not occupied, then false.
}
