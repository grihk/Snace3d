using UnityEngine;
using System.Collections;

public class FoodGeneration : MonoBehaviour
{
    public float XSitze = 8.8f;
    public float ZSitze = 8.8f;
    public GameObject foodPrefab;
    public Vector3 curPos;
    public GameObject curFood;
    
    void AddNewFood()
    {
        RandomPos();
        curFood = GameObject.Instantiate(foodPrefab, curPos, Quaternion.identity) as GameObject;

    }

    void RandomPos()
    {
        curPos = new Vector3(Random.Range(XSitze*-1,XSitze),0.25f,Random.Range(ZSitze*-1,ZSitze));
    }
    void Update()
    {
        if (!curFood)
        {
            AddNewFood();
        }
        else
        {
            return;
            
        }
       
    }
}
