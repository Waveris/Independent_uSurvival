﻿// Attach to the prefab for easier component access by the UI Scripts.
// Otherwise we would need slot.GetChild(0).GetComponentInChildren<Text> etc.
using UnityEngine;
using UnityEngine.UI;

public class UICharacterSelectionSlot : MonoBehaviour
{
    public Text nameText;
    public Image image;
    public Button selectButton;
    public Button deleteButton;

    public void OnPointerClick()
    {
        Debug.Log("Testing testing testing?!");
    }
}
