using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{
    public void SetItemWeight(ItemScriptableObject item)
    {
        item.weight = item.word.Length;
    }

    public int GetItemId(ItemScriptableObject item)
    {
        return item.itemId;
    }

    public string GetItemName(ItemScriptableObject item)
    {
        return item.itemName;
    }

    public GameObject GetItemObject(ItemScriptableObject item)
    {
        return item.itemObject;
    }

    public SpriteRenderer GetItemSprite(ItemScriptableObject item)
    {
        return item.itemSprite;
    }

    public string GetItemWord(ItemScriptableObject item) 
    {
        return item.word;
    }

    public int GetWordLength(ItemScriptableObject item)
    {
        return item.word.Length;
    }

    public bool CheckIsIncorrectWord(ItemScriptableObject item)
    {
        return item.isIncorrectWord;
    }

    public int GetItemWeight(ItemScriptableObject item)
    {
        return item.weight;
    }

    public void ShowItemDetails(ItemScriptableObject item)
    {
        Debug.Log("itemId: " + item.itemId + ", itemName: " + item.itemName + ", Name of itemObject: " + item.itemObject.name + ", Name of itemIcon: " + item.itemSprite.name + ", Incorrect word?; " + item.isIncorrectWord + ", Weight; " + item.weight);
    }
}