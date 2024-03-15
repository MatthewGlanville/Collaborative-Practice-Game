using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBloodCellShotScript : MonoBehaviour
{
    public GameObject target; 
    [SerializeField] private int movespeed = 20; 
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
                target.GetComponent<Bacteria>().takeDMG();
                Destroy(gameObject);
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
