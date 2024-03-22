using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawner : GameManager
{
    private bool TowerSpawned = false;
    [SerializeField] private GameObject RedBloodCell;
    [SerializeField] private GameObject WhiteBloodCell;
    [SerializeField] private GameObject Platelets;
    [SerializeField] private GameObject Mucus;
    [SerializeField] private GameObject StomachAcid;
    [SerializeField] private int redCost = 30;
    [SerializeField] private int whiteCost = 20;
    [SerializeField] private int plateletCost = 10;
    [SerializeField] private int mucusCost = 40;
    [SerializeField] private int acidCost = 25;
    private GameObject RedBloodClone;
    private GameObject WhiteBloodClone;
    private GameObject PlateletClone;
    private GameObject MucusClone;
    private GameObject StomachAcidClone; 
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnRedBloodCell()
    {
        if ((TowerSpawned == false) && (GameManager.Oxygen > 30))
        {
            GameManager.Oxygen -= redCost
                ; 
            RedBloodClone = Instantiate(RedBloodCell, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            TowerSpawned = true;
            Debug.Log("huh");
        }
    }
    public void SpawnWhiteBloodCell()
    {
        if ((TowerSpawned == false)&& (GameManager.Oxygen > 20))
        {
            GameManager.Oxygen -= whiteCost;
            WhiteBloodClone = Instantiate(WhiteBloodCell, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            TowerSpawned = true;
        }
    }
    public void SpawnPlatelets()
    {
        if ((TowerSpawned == false) && (GameManager.Oxygen > 10)) 
        {
            GameManager.Oxygen -= plateletCost;
            PlateletClone = Instantiate(Platelets, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            TowerSpawned = true;
        }
    }
    public void Sell()
    {
        if (PlateletClone != null)
        {
            Destroy(PlateletClone);
            GameManager.Oxygen += 5; 
        }
        else if (RedBloodClone != null)
        {
            Destroy(RedBloodClone);
            GameManager.Oxygen += 10; 
        }
        else if (WhiteBloodClone != null)
        {
            Destroy(WhiteBloodClone);
            GameManager.Oxygen += 15; 
        }
        else if (MucusClone != null)
        {
            Destroy(MucusClone);
            GameManager.Oxygen += 20;
        }
        else if (StomachAcidClone != null)
        {
            Destroy(StomachAcidClone);
            GameManager.Oxygen += 12; 
        }
    }
    public void SpawnMucus()
    {
        GameManager.Oxygen -= mucusCost;
        MucusClone = Instantiate(Mucus, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
        TowerSpawned = true;
    }
    public void SpawnAcid()
    {
        GameManager.Oxygen -= acidCost;
        StomachAcidClone = Instantiate(StomachAcid, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
        TowerSpawned = true; 
    }
}
