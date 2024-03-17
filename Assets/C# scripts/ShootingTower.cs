using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingTower : MonoBehaviour
{
    [SerializeField] GameObject CellShot;
    [SerializeField] private float attackDelay = 0.5f;
    private float delay;
    private List<GameObject> bacteriaInRange = new List<GameObject>(); 
    // Start is called before the first frame update
    void Start()
    { 
        delay= attackDelay;
    }

    // Update is called once per frame
    void Update()
    {
        delay -= Time.deltaTime; 
        if ((bacteriaInRange.Count != 0) && (delay <=0))
        {
            GameObject CellShotClone = Instantiate(CellShot, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            CellShotClone.GetComponent<ShotScript>().target = bacteriaInRange[Random.Range(0,bacteriaInRange.Count-1)] ;
            CellShotClone.transform.position = gameObject.transform.position;
            delay = attackDelay;
            
        }
    }
    void OnTriggerEnter2D(Collider2D coll) 
    {
        Debug.Log("a bacteria has entered");
        bacteriaInRange.Add(coll.gameObject);
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        Debug.Log("a bacteria has left");
        bacteriaInRange.Remove(coll.gameObject); 
    }
}
