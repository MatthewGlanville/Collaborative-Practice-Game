using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text OxygenUI;
    [SerializeField] private TMP_Text HealthUI;
    private static int oxygen = 300;
    public static int Oxygen
    {
        get { return oxygen; }
        set
        {
            if (value > 0)
            {
                oxygen = value; 
            }
        }
    }
    private static int health = 20;
    public static int Health
    {
        get { return health; }
        set
        {
            if (value < 20 && value > 0)
            {
                health = value; 
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        OxygenUI = OxygenUI.GetComponent<TMP_Text>();
        HealthUI = HealthUI.GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        OxygenUI.text = Oxygen.ToString();
        HealthUI.text = Health.ToString(); 
    }
}
