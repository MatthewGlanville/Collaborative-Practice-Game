using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderingSort : MonoBehaviour
{
    [SerializeField] private string layerName = "Layer 3";
    [SerializeField] private int sortingOrder = 3;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().sortingLayerName = layerName;
        gameObject.GetComponent<Renderer>().sortingOrder = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
