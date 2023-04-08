using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    [SerializeField]
    float speed = 1f;
    [SerializeField]
    float anSpeed = 5f;
    int t = 0;
    float waitTime = 1f;

    bool isInBound = true;
    [SerializeField]
    float force = 10f;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.angularVelocity = new Vector3(0, 0, Random.Range(1, anSpeed));
        Vector3 vector3 = new Vector3(0, 0, 0);
        rb.velocity = vector3;
        rb.AddForce(force,0,speed);

    }

    // Update is called once per frame
    void Update()
    {
        if (!isInBound)
        {
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
