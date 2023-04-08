using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource x;

    public float damageAmount = 10f;
    [SerializeField]
    GameObject explosion;
    public GameObject Exp;

    private void Start()
    {
        x = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        // Apply damage to the object if it has a Health script
        GenHealth otherHealth = collision.gameObject.GetComponent<GenHealth>();
        if (otherHealth != null && collision.gameObject.tag == "asteroid")
        {
      
            otherHealth.TakeDamage(damageAmount);
            Exp = Instantiate(explosion, collision.transform.position, Quaternion.identity);
            Destroy(Exp, 3);
            Destroy(this.gameObject);
        }
        
    }
    
}
