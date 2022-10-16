using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CraftDeck : MonoBehaviour
{
    public List<CraftDeckSlotScriptableObject> LoadCraftDeck()
    {
        CraftDeckSlotScriptableObject[] craftDeckSlots = Resources.LoadAll<CraftDeckSlotScriptableObject>("ScriptableObjects/CraftDeck/CraftSlots/");

        List<CraftDeckSlotScriptableObject> craftDeck = new List<CraftDeckSlotScriptableObject>(craftDeckSlots);

        return craftDeck;
    }
}
