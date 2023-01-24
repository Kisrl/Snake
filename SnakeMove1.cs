using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SnakeMove1 : MonoBehaviour
{
    public float speed;

    public List<GameObject> tailObjects = new List<GameObject>();

    public float Zoffset = -0.5f;

    public float RotationSpeed;

    public GameObject TailPrefab;

    public TextMeshProUGUI ScoreText;

    public int score = 0;

    void Start()
    {
        tailObjects.Add(gameObject); 
    }

    
    void Update()
    {
        ScoreText.text = score.ToString();

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down * RotationSpeed * Time.deltaTime);
        }
    }

    public void AddTail()
    {
        score++;

        Vector3 newTailPos = tailObjects[tailObjects.Count -1].transform.position;

        newTailPos.z -= Zoffset;

        tailObjects.Add( GameObject.Instantiate(TailPrefab, newTailPos, Quaternion.identity) as GameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Snake"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
