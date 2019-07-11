using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndLevel : MonoBehaviour
{
    private GameManager theGameManager;
    public int nextLevel;

    void Start()
    {
        theGameManager = FindObjectOfType<GameManager>();

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {

            //theGameManager.PauseGame();
            StartCoroutine(theGameManager.NextLevel(nextLevel));
            Debug.Log("Next Level");
        }
    }
}
