using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class itemSlot : MonoBehaviour
{
    //=======ITEM Data========//
    public string itemName;
    public int quantity;
    public Sprite itemSprite;
    public bool isFull;


    //=======ITEM SLOT========//
    [SerializeField]
    private TMP_Text quantityText;
    [SerializeField]
    private Image itemImage;

    public void Additem(string itemName, int quantity, Sprite itemSprite)
    {
        this.itemName = itemName;
        this.quantity = quantity;
        this.itemSprite = itemSprite;
        isFull = true;

        quantityText.text = quantity.ToString();
        quantityText.enabled = true;
        itemImage.enabled = true;
        itemImage.sprite = itemSprite;
    }


   
}
