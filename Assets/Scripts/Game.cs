using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Material wallMaterial;
    public static int points;
    public int countWals = 10;
    public GameObject wallPrefab;

    private string _pointsString;
    private int _lastPoints = -1;
    public void Awake()
    {
        points = 0;
        GenerateLevel();
    }
    public void Update()
    {
        if (_lastPoints == points) return;
        _lastPoints = points;
        _pointsString = "Score:" + points.ToString("0000");
    }
    public void OnGUI()
    {
        GUI.color = Color.yellow;
        GUI.Label(new Rect(205, 5, 200, 20), _pointsString ?? "");
    }
    private void GenerateLevel()
    {
        for (int i = 0; i < countWals; i++)
        {
            GameObject wall = GameObject.CreatePrimitive(PrimitiveType.Cube);
            wall.name = "Wall";
            wall.transform.localScale = new Vector3(1, 1, 1);

            var pos = new Vector3(Random.Range(-8, 8), 0, Random.Range(-8, 8));
            while (Mathf.Abs(pos.x) < 5 || Mathf.Abs(pos.z) < 5)
            {
                pos = new Vector3(Random.Range(-8, 8), 0, Random.Range(-8, 8));
            }

            wall.transform.position = pos;
            wall =  wallPrefab;
        }
    }
}

