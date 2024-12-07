using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelEnd : MonoBehaviour
{
    //GameObject for the winning text.
    public GameObject WinTextObject;
    

    //On collision enter that causes the target to despawn after a bullet hits it.
    public void OnCollisionEnter2D(Collision2D other)
    {
        //Sets the target to inacgtive after getting hit by a Bullet.
        if (other.gameObject.CompareTag("Bullet"))
        {
            other.gameObject.SetActive(false);
            
        }
        
        //Gets tag for the Target and sets the iwn tect to true after hitting it.
        if(other.gameObject.CompareTag("Target"))
        {
            WinTextObject.SetActive(true);
        }
    }


}
