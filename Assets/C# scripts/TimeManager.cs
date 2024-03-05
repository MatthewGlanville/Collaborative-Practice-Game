using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using TMPro; 
public class TimeManager : MonoBehaviour
{
    [SerializeField] private TMP_Text TimeUI;
    private float timeLeft = 90;
    public float TimeLeft
    {
        get { return timeLeft; }
        set
        {
            if (value < 0)
            {
                value = 0.0f;
            }
            if (value < timeLeft )
            {
                timeLeft = value; 
            }
        }
    }
    private bool paused = false; 
    public bool Paused
    {
        get { return paused; }
        set
        {
            paused = value; 
        }
    }
    private string timeString; 
    // Start is called before the first frame update
    void Start()
    {
        TimeUI = TimeUI.GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (paused == false)
        {
            TimeLeft -= Time.deltaTime;
            if (TimeLeft == 0)
            {
                SceneManager.LoadScene("GameWonScene");
            }
            else
            {
                timeString = TimeLeft.ToString(); // gets the timer value to 1 decimal place. 
                timeString = timeString.Substring(0, 4);
                TimeUI.text = timeString;
            }
        }
    }
}
