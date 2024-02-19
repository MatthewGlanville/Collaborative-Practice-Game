using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISpawner : MonoBehaviour
{
    [SerializeField] private GameObject TowerUI;
    private bool UISpawned = false;
    private GameObject clone;
    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnTowerUI()
    {
        if (UISpawned == false)
        {
            clone = Instantiate(TowerUI, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            UISpawned = true;
            Debug.Log(UISpawned);
        }
        else if (UISpawned == true)
        {
            Destroy(clone); //fucking DESTROY THE CLONE YOU BRAINDEAD MACHINE
            UISpawned = false;
        }
    }
}
