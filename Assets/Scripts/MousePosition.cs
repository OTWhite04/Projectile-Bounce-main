using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour
{
    //Variable for the camera in the scene.
    Camera cam;

    Vector2 MousePos
    {
        get
        {
            //Vector for the mouse position, making equal to the mouse position on the camera. 
            Vector2 MousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            //Returns the actual mouse Position.
            return MousePos;
        }
    }
    
    //Awake method.
    private void Awake()
    {
        //Makes the cam variable the main camera in the scene.
        cam = Camera.main;
    }

    //Update method.
    private void Update()
    {
        //Vector direction 
        Vector2 dir = (Vector2)transform.position - MousePos;
        //A float angle that 
        float angle = (Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg);
       
        transform.eulerAngles = new Vector3(0f, 0f, angle);
        //Fixes mouse position offset and makes Gun face correct direction.
        transform.eulerAngles = new Vector3(0f, 0f, angle + 180f);
    }







}
