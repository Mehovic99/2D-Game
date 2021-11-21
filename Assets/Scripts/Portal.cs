using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    private Transform destination;

    public bool isDeath;
    public float distance = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        if (isDeath == false)
        {
            destination = GameObject.FindGameObjectWithTag("Life").GetComponent<Transform>();
        } else
        {
            destination = GameObject.FindGameObjectWithTag("Death").GetComponent<Transform>();
        }
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (Vector2.Distance(transform.position, other.transform.position) > distance)
        {
            other.transform.position = new Vector2(destination.position.x, destination.position.y);
        }
    }
}
