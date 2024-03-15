using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; 
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
    public static void takeDmg()
    {
        health -= 1; 
        if (health < 0)
        {
            SceneManager.LoadScene("GameLostScene");
        }
    }
}
