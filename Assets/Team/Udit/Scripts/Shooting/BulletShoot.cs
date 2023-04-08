using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    public AudioSource bulletShoot;

    public GameObject bulletPrefab;    // The bullet prefab to spawn
    public float bulletSpeed = 20f;    // The speed of the bullet
       // The amount of damage the bullet applies

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            // Spawn a new bullet
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);  
            bulletShoot.Play();

            // Apply velocity to the bullet
            Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();
            bulletRigidbody.velocity = transform.forward * bulletSpeed;
        }
    }

}
