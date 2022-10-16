using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Scriptableobjects/Item", order = 1)]
public class ItemScriptableObjectClass : ScriptableObject
{
    public int id;
    public GameObject itemObject;
    public SpriteRenderer itemIcon; // 2d sprite image of the item object to be shown on inventory.
    public string word;
    public bool isIncorrectWord; // if the spelling of this word is incorrect, then true. if correct spelling, then false.
    public int weight; // weight is calcurated based on the number of characters of this word.

    public void ShowItemDetails()
    {
        Debug.Log("Id: " + id + ", Name of itemObject: " + itemObject.name + ", Name of itemIcon: " + itemIcon.name + ", Incorrect word?; " + isIncorrectWord + ", Weight; " + weight);
    }
}
