using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bacteria : GameManager
{
    [SerializeField] private float moveSpeed = 5.0f;
    [SerializeField] private float health = 20;
    [SerializeField] private List<GameObject> Points;
    private float maxMoveSpeed;
    private int pointIndex; 
    private GameObject pointChased; 
    private float stunTimer = 0;
    private float slowTimer = 0; 
    // Start is called before the first frame update
    void Start()
    {
            pointChased = Points[0];
            Debug.Log(pointChased.transform.position);
            maxMoveSpeed = moveSpeed; 
    }

    // Update is called once per frame
    void Update()
    {
        if (stunTimer <= 0)
        {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, pointChased.transform.position, moveSpeed * Time.deltaTime);
            if (gameObject.transform.position == pointChased.transform.position)
            {
                pointIndex += 1;
                if (pointIndex > Points.Count - 1)
                {
                    GameManager.takeDmg();
                    Destroy(gameObject);
                }
                else
                {
                    pointChased = Points[pointIndex];
                }
            }
        }
        else
        {
            stunTimer -= Time.deltaTime; 
        }
        if (slowTimer > 0)
        {
            slowTimer -= Time.deltaTime;
            if (slowTimer <= 0)
            {
                moveSpeed = maxMoveSpeed;
            }
        }
        
    }
    public void takeDMG()
    {
        Debug.Log("owwiee");
        health -= 1; 
        if (health < 0)
        {
            Destroy(gameObject);
        }
    }
    public void trap()
    {
        takeDMG();
        stunTimer = 0.5f;
    }
    public void slow()
    {
        moveSpeed = maxMoveSpeed / 2;
        slowTimer = 1.5f;
    }
}
