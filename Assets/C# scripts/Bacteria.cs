using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bacteria : GameManager
{
    [SerializeField] private float movespeed = 5;
    [SerializeField] private float health = 20;
    [SerializeField] private List<GameObject> Points;
    private int pointIndex; 
    private GameObject pointChased; 
    private bool passedPoint1 = false; 
    private float xMove = 3;
    private float yMove = 0;
    // Start is called before the first frame update
    void Start()
    {
            pointChased = Points[0];
            Debug.Log(pointChased.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, pointChased.transform.position, movespeed * Time.deltaTime);
        if (gameObject.transform.position == pointChased.transform.position)
        {
            pointIndex += 1;
            if (pointIndex > Points.Count-1)
            {
                GameManager.takeDmg();
                Destroy(gameObject);
            }
            else {
                pointChased = Points[pointIndex];
            }
        }
        
    }
    public void takeDMG()
    {
        health -= 1; 
        if (health < 0)
        {
            Destroy(gameObject);
        }
    }
}
