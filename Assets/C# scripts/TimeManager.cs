using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
                value = 0;
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
            string timeString = TimeLeft.ToString();
            timeString = timeString.Substring(0, 4);
            TimeUI.text = timeString; 
        }
    }
}
