using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StomachAcidTower : MonoBehaviour
{
    [SerializeField] private GameObject acidShot;
    [SerializeField] private float spawnDelay = 1.0f;
    [SerializeField] private List<GameObject> Points;
    [SerializeField] private float Range = 10.0f;
    private GameObject acidShotClone; 
    private List<GameObject> pointsInRange = new List<GameObject>(); 
    private float delay; 

    // Start is called before the first frame update
    void Start()
    {
        delay = spawnDelay; 
        for (int i=0; i < Points.Count; i++)
        {
            if ((Points[i].transform.position.x < gameObject.transform.position.x + Range) && (Points[i].transform.position.x> gameObject.transform.position.x - Range)){
                if ((Points[i].transform.position.y < gameObject.transform.position.y + Range) && (Points[i].transform.position.y > gameObject.transform.position.y - Range))
                {
                    pointsInRange.Add(Points[i]);
                }

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        delay -= Time.deltaTime;
        if (delay <= 0)
        {
            acidShotClone = Instantiate(acidShot, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            acidShotClone.GetComponent<AcidShot>().target = pointsInRange[Random.Range(0, pointsInRange.Count - 1)];
            acidShotClone.transform.position = gameObject.transform.position;
            delay = spawnDelay;
        }
    }
}
