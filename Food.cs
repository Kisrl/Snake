using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Snake"))
        {
            other.GetComponent<SnakeMove>().AddTail();
            Destroy(gameObject);
        }
        if (other.CompareTag("Snake1"))
        {
            other.GetComponent<SnakeMove1>().AddTail();
            Destroy(gameObject);
        }
    }
}
