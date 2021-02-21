using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
[RequireComponent(typeof(Button))]

public class UIButtons : OverrideUI
{
    protected Button button;
    protected Image image;

    public ButtonType buttonType;

    public enum ButtonType
    {
        Default,
        Confirm,
        Decline,
        Warning
    }

    public override void Awake()
    {
        button = GetComponent<Button>();
        image = GetComponent<Image>();

        base.Awake();
    }

    protected override void OnUIData()
    {
        button.transition = Selectable.Transition.SpriteSwap;
        button.targetGraphic = image;

        image.sprite = uiData.buttonSprite;
        image.type = Image.Type.Sliced;
        button.spriteState = uiData.buttonSpriteState;

        switch (buttonType)
        {
            case ButtonType.Confirm:
                image.color = uiData.confirmColor;
                break;
            case ButtonType.Decline:
                image.color = uiData.declineColor;
                break;
            case ButtonType.Default:
                image.color = uiData.defaultColor;
                break;
            case ButtonType.Warning:
                image.color = uiData.warningColor;
                break;
        }


        base.OnUIData();
    }
}
