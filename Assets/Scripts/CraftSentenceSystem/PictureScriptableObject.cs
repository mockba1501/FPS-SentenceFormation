using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Picture", menuName = "Scriptableobjects/Picture", order = 1)]
public class PictureScriptableObject : ScriptableObject
{
    public int pictureId;
    public string pictureName;
    public Sprite pictureSprite; // 2d sprite image of the picture to be shown on picture deck of craft system.
    public string correctSentence;
}