using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bacteria : MonoBehaviour
{
    [SerializeField] private float movespeed = 5;
    [SerializeField] private float health = 20;
    private float xMove = 3;
    private float yMove = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        gameObject.transform.position = gameObject.transform.position + new Vector3(xMove * movespeed * Time.deltaTime, yMove * movespeed * Time.deltaTime, 0);
        if (gameObject.transform.position.x > 3.5)
        {
            Destroy(gameObject);
        }
        
    }
}
