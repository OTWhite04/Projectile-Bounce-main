using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    //public GameObject particles;

    //Rigidbody for the bullet.
    [SerializeField] Rigidbody2D rb;
    //Float speed for the bullet.
    [SerializeField] float speed = 30f;
    //Lives for the Bullet that will destroy it.
    [SerializeField] int life = 3;
   
    //Vector 2 direction for the direction of the Bullet.
    private Vector2 direction;

    public void Shoot(Vector2 direction)
    {
        this.direction = direction;
        rb.velocity = this.direction * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        life--;
        if(life < 0)
        {
            Destroy(gameObject);
            return;
        }
    }


    //public void OnCollisionEnter2D(Collision2D other)
    //{
    //   GameObject burst = Instantiate(particles,this.transform.position);
        
    //}
}
