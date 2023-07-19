using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Item Data", menuName = "Scriptable Object/Item", order = 1)]
public class ItemData : ScriptableObject
{
    public int itemNumber;
    //0은 공백(빈칸)
    public string itemName;
    //아이템의 이름
    public Sprite itemImage;
    //아이템의 스프라이트
    public int itemWeight;
    //아이템 무게
    public int itemType;
    //아이템 종류
    public string itemInfo;
    //아이템 설명
    public ItemStat[] itemStats;

}
[System.Serializable]
public class ItemStat
{
    public int dataType;
    public float amount;
}
