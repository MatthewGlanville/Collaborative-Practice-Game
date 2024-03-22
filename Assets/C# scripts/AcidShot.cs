using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidShot : MonoBehaviour
{
    public GameObject target;
    [SerializeField] private int durability = 4;
    [SerializeField] private float duration = 10.0f;
    [SerializeField] private int movespeed = 10; 
    private bool found = false; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (found == false)
        {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, target.transform.position, movespeed * Time.deltaTime);
            if (gameObject.transform.position == target.transform.position)
            {
                found = true; 
            }
        }
        duration -= Time.deltaTime; 
        if (duration <= 0)
        {
            Destroy(gameObject); 
        }

    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        coll.gameObject.GetComponent<Bacteria>().takeDMG();
        durability -= 1;
        if (durability == 0)
        {
            Destroy(gameObject); 
        }
    }
}
