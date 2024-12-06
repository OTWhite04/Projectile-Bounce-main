using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GunScript : MonoBehaviour
{

    [SerializeField] Bullet bulletprefab;
    [SerializeField] Transform bulletSpawnPos;


    private Camera cam;

    Vector2 MousePos
    {
        get
        {
            Vector2 Pos = cam.ScreenToWorldPoint(Input.mousePosition);
            return Pos;
        }
    }

    // Start is called before the first frame update
    void Awake()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector2 direction = MousePos - (Vector2)transform.position;
            Bullet bullet = Instantiate(bulletprefab, bulletSpawnPos.position, Quaternion.identity);
            bullet.Shoot(direction.normalized);
        }
    }
}
