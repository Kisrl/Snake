using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TailMove1 : MonoBehaviour
{
    public float speed;

    public SnakeMove1 Snake;

    public Vector3 lastTail;

    public int indx;

    public GameObject lastTailObj;


    void Start()
    {
        Snake = GameObject.FindGameObjectWithTag("Snake1").GetComponent<SnakeMove1>();
        speed = Snake.speed+1;
        lastTailObj = Snake.tailObjects[Snake.tailObjects.Count -2];
        indx = Snake.tailObjects.IndexOf(gameObject);
    }

    void Update()
    {
        lastTail = lastTailObj.transform.position;
        transform.LookAt(lastTail);
        transform.position = Vector3.Lerp(transform.position, lastTail, Time.deltaTime * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Snake1"))
        {
            if (indx > 2)
            {
                SceneManager.LoadScene("GameOver");
            }

        }
        if (indx == 30)
        {
            SceneManager.LoadScene("Win");
        }

    }
}
