using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInfo : MonoBehaviour
{
    private Image itemImage;
    private int itemType;
    [SerializeField]
    private ItemData item;
    public ItemData Item
    {
        get { return item; }
        set
        {
            item = value;
            if(item != null)
            {
                itemImage.sprite = item.itemImage;
                itemImage.color = new Color(1, 1, 1, 1);
            }
        }
    }
}
