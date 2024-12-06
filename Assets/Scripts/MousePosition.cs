using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour
{
    Camera cam;

    Vector2 MousePos
    {
        get
        {
            Vector2 MousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            return MousePos;
        }
    }

    private void Awake()
    {
        cam = Camera.main;
    }


    private void Update()
    {
        Vector2 dir = (Vector2)transform.position - MousePos;
        float angle = (Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg);
        transform.eulerAngles = new Vector3(0f, 0f, angle);
        transform.eulerAngles = new Vector3(0f, 0f, angle + 180f);
    }







}
