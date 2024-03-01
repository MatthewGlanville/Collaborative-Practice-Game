using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuScript : MonoBehaviour
{
    [SerializeField] private Sprite newSprite;
    private float delay = 0.3f;
    bool delayStarted = false; 
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (delayStarted== true)
        {
            delay -= Time.deltaTime; 
            if (delay < 0)
            {
                SceneManager.LoadScene("GameScene");
            }
        }
    }
    public void StartGame()
    {
        gameObject.GetComponent<Image>().sprite = newSprite;
        delayStarted = true; 
    }
}
