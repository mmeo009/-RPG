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
    //0�� ����(��ĭ)
    [SerializeField]
    private string itemName;
    public string ItemName { get { return itemName; } }
    //�������� �̸�
    [SerializeField]
    private Sprite itemImage;
    public Sprite ItemImage { get { return itemImage; } }
    //�������� ��������Ʈ
    [SerializeField]
    private int itemWeight;
    public int ItemWeight { get { return itemWeight; } }
    //������ ����
    [SerializeField]
    private int addPoint;
    public int AddPoint { get { return addPoint; } }
    //������
    [SerializeField]
    private int decreasePoint;
    public int DecreasePoint { get { return decreasePoint; } }
    //�������


}
