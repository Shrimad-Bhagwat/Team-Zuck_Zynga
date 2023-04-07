using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Metero_Movement : MonoBehaviour
{
    [SerializeField]
    float speed = 10f;
    [SerializeField]
    float screenBound = 2.8f;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, speed);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z >= screenBound * 1.4)
        {
            Destroy(this.gameObject);
        }
        
    }
}
