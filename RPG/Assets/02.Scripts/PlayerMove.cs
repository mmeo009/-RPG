using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private void Reset()
    {

    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        }
    }
}
