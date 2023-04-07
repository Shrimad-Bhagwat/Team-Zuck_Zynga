using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    float _speedRotation = 10f;
    [SerializeField]
    float _rotationAngle = 20f;
    [SerializeField]
    float _speedTarget = 1f;
    [SerializeField]
    float _speedShip = 1f;

    Vector3 _direction = Vector3.zero;
    Vector3 _rotation = Vector3.zero;
    Vector2 _screenbound;
    [SerializeField]
    GameObject target;

    private void Start()
    {
        target.transform.rotation = Quaternion.Euler(0, 180, 0);
        _screenbound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z)); 
    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.transform.position, _speedShip * Time.deltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, target.transform.rotation, _speedRotation * Time.deltaTime);


        if (Input.GetKey(KeyCode.A))
        {
            _direction.x = 1;
            target.transform.position += _direction * _speedTarget * Time.deltaTime;
            target.transform.rotation = Quaternion.Euler(0, 180, _rotationAngle);
        }
         if(Input.GetKey(KeyCode.D))
        {
            _direction.x = -1;
            target.transform.position += _direction * _speedTarget * Time.deltaTime;
            target.transform.rotation = Quaternion.Euler(0, 180, -_rotationAngle);
        }
         if(Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D)) 
         {
            _direction.x = 0;
            target.transform.rotation = Quaternion.Euler(0, 180, 0);
         }
         if(!Input.anyKey)
        {
            target.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }
}
