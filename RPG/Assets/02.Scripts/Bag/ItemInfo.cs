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
    private GameObject infomation;
    private void Awake()
    {
        itemImage = GetComponent<Image>();
        infomation = GameObject.Find("ToolTip");
    }
    private void Start()
    {
        if (item != null)
        {
            itemImage.sprite = item.itemImage;
            itemImage.color = new Color(1, 1, 1, 1);
        }
        else
        {
            Debug.Log("cant access ScriptableObject");
        }
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(2))
        {
        }
    }
}
