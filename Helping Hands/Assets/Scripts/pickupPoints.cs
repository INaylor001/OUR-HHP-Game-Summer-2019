using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupPoints : MonoBehaviour
{

    private ItemManager theItemManager; // what references the item that changes the count
    private ScoreManager theScoreManager; //what references to the score

    public int scoreValue; //should be +1
    public int pointValue; //adds to the level score

    // Start is called before the first frame update
    void Start()
    {
        theItemManager = FindObjectOfType<ItemManager>();
        theScoreManager = FindObjectOfType<ScoreManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            theItemManager.AddItemCount(scoreValue);
            theScoreManager.AddScore(pointValue);
            gameObject.SetActive(false);
        }
    }
}
