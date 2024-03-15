using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BacteriaSpawner : MonoBehaviour
{
    [SerializeField] private GameObject Bacteria;
    private GameObject BacteriaClone;
    [SerializeField] private float spawnSpeed;
    private float delay;
    // Start is called before the first frame update
    void Start()
    {
        delay = spawnSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        delay -= Time.deltaTime;
        if (delay <= 0)
        {
            delay = spawnSpeed;
            BacteriaClone = Instantiate(Bacteria, new Vector3(-10,-4,0), Quaternion.identity);
        }
    }
}
