using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boulder : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Snake"))
        {
            SceneManager.LoadScene("GameOver");
        }
        if (other.CompareTag("Snake1"))
        {
            SceneManager.LoadScene("GameOver");
        }


    }
}
