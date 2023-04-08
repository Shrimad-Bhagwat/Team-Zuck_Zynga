using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testPrint : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("5 seconds has passed");
    }
}
