using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryOnOff : MonoBehaviour
{
    public bool able = false;

    public GameObject inventoryCanvus;
    private void Update()
    {
        inventoryCanvus.active = able;
        if (Input.GetKeyDown(KeyCode.I))
        {
            able = !able;
        }
    }
}
