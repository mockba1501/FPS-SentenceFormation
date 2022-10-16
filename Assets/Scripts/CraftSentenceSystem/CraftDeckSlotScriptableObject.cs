using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CraftDeckSlot", menuName = "Scriptableobjects/CraftDeck/CraftDeckSlot", order = 1)]
public class CraftDeckSlotScriptableObject : ScriptableObject
{
    public int craftDeckSlotId;
    public ItemScriptableObject itemInCraftDeckSlot;
    public bool isOccupied; // if item is in this slot, then true. if not occupied, then false.
}
