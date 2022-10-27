using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Scriptableobjects/Item", order = 1)]
public class ItemScriptableObject : ScriptableObject
{
    public int itemId;
    public string itemName;
    public GameObject itemObject;
    public Sprite itemSprite; // 2d sprite image of the item object to be shown on inventory.
    public string word;
    public bool isIncorrectWord; // if the spelling of this word is incorrect, then true. if correct spelling, then false.
    public bool isInInventory; // if the item is in Inventory, then true. if the item is not in Inventory, then false.
    public bool isInCraftDeck; // if the item is in CraftDeck, then true. if the item is not in CraftDeck, then false.
    public int weight; // weight is calcurated based on the number of characters of this word.
}