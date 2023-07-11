using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        ItemDrag draggableItem = dropped.GetComponent<ItemDrag>();
        draggableItem.parentAfterDrag = transform;
    }
}
