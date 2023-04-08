using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{
    
    public int points = 0;
    Collisoin x;
    [SerializeField]
    TextMeshProUGUI Score_txt , Lives_txt;
    private void Start()
    {
        StartCoroutine(pointCount());
        Debug.Log(points);
        x = this.GetComponent<Collisoin>();
    }
   
    public void add(int increase)
    {
        points += increase;
    }

    private void Update()
    {
        int life = x.returnLife() + 1;
        Score_txt.text = "Score : "+points.ToString();
        Lives_txt.text = "Lives: " + life.ToString();
    }
    // Update is called once per frame
    IEnumerator pointCount()
    {
        yield return new WaitForSeconds(1f);
        Debug.Log(points);
    }
}
