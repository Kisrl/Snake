using System.Collections;
using UnityEngine;

public class FoodGeneration : MonoBehaviour
{
    public float XSize = 8.6f;

    public float ZSize = 8.5f;
    
    public GameObject FoodPrefab;

    public GameObject curFood;

    public Vector3 curPos;
   

    void AddNewFood()
    {
        RandomPos();
        curFood = GameObject.Instantiate(FoodPrefab, curPos, Quaternion.identity) as GameObject;
    }

    void RandomPos()
    {
        curPos = new Vector3(Random.Range(XSize * -1, XSize), 0.25f, Random.Range(ZSize * -1, ZSize));
    }
    void Update()
    {
        if(!curFood)
        {
            AddNewFood();
        }
        else
        {
            return;
        }
    }
   
}
