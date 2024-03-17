using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScript : MonoBehaviour
{
    public GameObject target; 
    [SerializeField] private int movespeed = 20;
    [SerializeField] private string shotType = "w"; // denotes the shot type, makes the scripts more reusable 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, target.transform.position, movespeed * Time.deltaTime);
            if (gameObject.transform.position == target.transform.position)
            {
                Debug.Log("me hit :)");
                if (shotType == "w")
                {
                    target.GetComponent<Bacteria>().takeDMG();
                }
                else if (shotType == "m")
                {
                    target.GetComponent<Bacteria>().trap();
                }
                else if (shotType == "p")
                {
                    target.GetComponent<Bacteria>().slow();
                }
                Destroy(gameObject);
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
