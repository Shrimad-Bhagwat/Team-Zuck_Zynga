using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collisoin : MonoBehaviour
{
    public int lifes = 2;
    public GameObject exp;
    [SerializeField]
    GameObject explosion;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "asteroid")
        {
            lifes--;
            if (lifes<0)
            {
                exp = Instantiate(explosion, this.transform.position, Quaternion.identity);
                Destroy(exp, 3);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                transform.gameObject.SetActive(false);
            }

            collision.gameObject.SetActive(false);
            exp = Instantiate(explosion, collision.transform.position, Quaternion.identity);
            Destroy(exp, 3);

        }
    }

    public int returnLife()
    {
        return lifes;
    }
}
