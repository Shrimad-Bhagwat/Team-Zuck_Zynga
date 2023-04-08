using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GenHealth: MonoBehaviour
{
    public float maxHealth = 100f;   // The maximum health of the object
    private float currentHealth;     // The current health of the object
    // Start is called before the first frame update
    Points p;
    GameObject ship;
    void Start()
    {
        currentHealth = maxHealth;
        try
        {

        ship = GameObject.FindGameObjectsWithTag("Player")[0];
        }catch(System.Exception) { Debug.Log("Error"); }
        p = ship.GetComponent<Points>();
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
        p.add(5);
        Destroy(this.gameObject);
    }
}
