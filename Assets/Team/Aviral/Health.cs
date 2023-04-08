using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHealth = 100f;   // The maximum health of the object
    private float currentHealth;     // The current health of the object

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Apply damage to the object
    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    // Destroy the object
    private void Die()
    {
        Destroy(gameObject);
    }
}
