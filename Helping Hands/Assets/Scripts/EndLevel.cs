using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            theGameManager.NextLevel(nextLevel);
            Debug.Log("Next Level");
        }
    }
}
