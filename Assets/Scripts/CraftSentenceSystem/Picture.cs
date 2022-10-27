using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picture : MonoBehaviour
{
    public int GetPictureId(PictureScriptableObject picture)
    {
        return picture.pictureId;
    }

    public string GetPictureName(PictureScriptableObject picture)
    {
        return picture.pictureName;
    }

    public Sprite GetPictureSprite(PictureScriptableObject picture)
    {
        return picture.pictureSprite;
    }

    public string GetCorrectSentenceFromPicture(PictureScriptableObject picture)
    {
        return picture.correctSentence;
    }

    public void ShowPictureDetails(PictureScriptableObject picture)
    {
        Debug.Log("pictureId: " + picture.pictureId + ", Name of picture: " + picture.pictureName + ", Name of pictureSprite: " + picture.pictureSprite.name + ", Correct sentence; " + picture.correctSentence);
    }
}