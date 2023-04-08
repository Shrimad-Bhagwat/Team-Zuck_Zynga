using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Metero_Movement : MonoBehaviour
{
    [SerializeField]
    float speed = 1f;
    [SerializeField]
    float anSpeed = 5f;
    int t = 0;
    float waitTime = 1f;
    GameObject ship;

    bool isInBound = true;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.angularVelocity = new Vector3(0, 0, Random.Range(1, anSpeed));
        Vector3 vector3 = new Vector3(0, 0, speed);
        rb.velocity = vector3;
        try
        {

        ship = GameObject.FindGameObjectsWithTag("Player")[0];
        }
        catch
        {
            Debug.Log("Game Over");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!isInBound)
        {
            ship.GetComponent<Points>().add(1);
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("PlayArea") == true)
        {
            isInBound = false;
        }
    }

}
