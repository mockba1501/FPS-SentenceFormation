using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PictureSlot : Picture
{
    public GameObject pictureSlot;
    public TMPro.TMP_Text pictureText;
    public PictureScriptableObject pictureSO;

    public void Start()
    {
        ShowPictureDetail();
    }

    public void ShowPictureDetail()
    {
        if (pictureSO)
        {
            pictureSlot.GetComponent<Image>().sprite = pictureSO.pictureSprite;
            pictureText.text = pictureSO.correctSentence;//Test purpose. When crfting sentence, not to be showed the correctsentence.

            Debug.Log("PictureID: " + pictureSO.pictureId + "\n" + "Correct Sentence about Picture: " + pictureSO.correctSentence + "\n" + "Name of picture" + pictureSO.pictureSprite.name); // Just a test to show picture details in picture slot panel. 
        }
    }
}
