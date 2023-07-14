using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Item Data", menuName = "Scriptable Object/Item Data", order = 1)]
public class ItemData : ScriptableObject
{
    [SerializeField]
    private int itemNumber;
    public int ItemNumber { get { return itemNumber; } }
    //0은 공백(빈칸)
    [SerializeField]
    private string itemName;
    public string ItemName { get { return itemName; } }
    //아이템의 이름
    [SerializeField]
    private Sprite itemImage;
    public Sprite ItemImage { get { return itemImage; } }
    //아이템의 스프라이트
    [SerializeField]
    private int itemWeight;
    public int ItemWeight { get { return itemWeight; } }
    //아이템 무게
    [SerializeField]
    private int addPoint;
    public int AddPoint { get { return addPoint; } }
    //버프량
    [SerializeField]
    private int decreasePoint;
    public int DecreasePoint { get { return decreasePoint; } }
    //디버프량


}
