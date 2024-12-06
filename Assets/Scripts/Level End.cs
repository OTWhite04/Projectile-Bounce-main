using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelEnd : MonoBehaviour
{
    public GameObject WinTextObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //On collision enter that causes the target to despawn after a bullet hits it.
    public void OnCollisionEnter2D(Collision2D other)
    {
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
