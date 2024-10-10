using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dongle1 : MonoBehaviour
{


    void Update()
    {
       
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            mousePos.y = 8;
            mousePos.z = 0;
            transform.position = Vector3.Lerp(transform.position, mousePos, 0.2f);
       
    }
}
