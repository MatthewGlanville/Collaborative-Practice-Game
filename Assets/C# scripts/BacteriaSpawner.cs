using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BacteriaSpawner : MonoBehaviour
{
    [SerializeField] private GameObject Bacteria;
    private GameObject BacteriaClone;
    private float delay = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delay -= Time.deltaTime;
        if (delay <= 0)
        {
            delay = 5.0f;
            BacteriaClone = Instantiate(Bacteria, new Vector3(-10,-4,0), Quaternion.identity);
        }
    }
}
