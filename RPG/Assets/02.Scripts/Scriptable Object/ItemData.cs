using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Item Data", menuName = "Scriptable Object/Item", order = 1)]
public class ItemData : ScriptableObject
{
    public int itemNumber;
    //0�� ����(��ĭ)
    public string itemName;
    //�������� �̸�
    public Sprite itemImage;
    //�������� ��������Ʈ
    public int itemWeight;
    //������ ����
    public int itemType;
    //������ ����
    public string itemInfo;
    //������ ����
    public ItemStat[] itemStats;

}
[System.Serializable]
public class ItemStat
{
    public int dataType;
    public float amount;
}
