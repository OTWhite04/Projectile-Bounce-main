using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    //public GameObject particles;

    public GameObject LoseTextObject;
    //Rigidbody for the bullet.
    [SerializeField] Rigidbody2D rb;
    //Float speed for the bullet.
    [SerializeField] float speed = 30f;
    //Lives for the Bullet that will destroy it.
    [SerializeField] int life = 8;
    //Variable for counting reflects of the bullet.
    public int BulletCount;
   
    //Vector 2 direction for the direction of the Bullet.
    private Vector2 direction;

    //Method for shooting the bullet
    public void Shoot(Vector2 direction)
    {
        this.direction = direction;
        rb.velocity = this.direction * speed;

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Takes away life from the Bullet.
        life--;
        //Checks if Bullets life is less than zero and destroys it.
        if(life < 0)
        {
            Destroy(gameObject);
            return;
        }

        //Counts another Bullet every time one is fired.
        BulletCount++;
        //If statement for Bullet count equaling five.
        if (BulletCount == 8)
        {
            //Lets player know they lost.
            LoseTextObject.SetActive(true);


        }

        var firstContact = collision.contacts[0];
        Vector2 newVelocity = Vector2.Reflect(direction.normalized, firstContact.normal);
        Shoot(newVelocity.normalized);
    }

    

    //public void OnCollisionEnter2D(Collision2D other)
    //{
    //   GameObject burst = Instantiate(particles,this.transform.position);
        
    //}
}
