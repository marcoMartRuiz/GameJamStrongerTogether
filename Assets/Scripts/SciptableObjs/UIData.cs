using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "New UIData", menuName = "UIData")]
public class UIData : ScriptableObject
{
   public Sprite buttonSprite;
    public SpriteState buttonSpriteState;

    public Color defaultColor;
    public Color confirmColor;
    public Color declineColor;
    public Color warningColor;

    
}
