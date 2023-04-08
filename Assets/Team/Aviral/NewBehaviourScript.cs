using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float damageAmount = 10f;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hit");
        // Get the object that the bullet hit
        GameObject other = collision.gameObject;

        // Apply damage to the object if it has a Health script
        Health otherHealth = collision.gameObject.GetComponent<Health>();
        if (otherHealth != null)
        {
            otherHealth.TakeDamage(damageAmount);
        }

        // Destroy the bullet
        Destroy(gameObject);
    }
    // Update is called once per frame

}
