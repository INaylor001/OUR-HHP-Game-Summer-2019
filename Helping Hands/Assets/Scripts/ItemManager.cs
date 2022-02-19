using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public Text itemText;

    public float itemCount;
    public string itemName;
    public float total;
    //private bool allItems;
    private GameManager theGameManager;
    public bool collect; //is the level a collectathon

    
    // Start is called before the first frame update
    void Start()
    {
        //allItems = false;
        theGameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (itemCount >= total && collect)
        {
            StartCoroutine(theGameManager.NextLevel(theGameManager.nextLev));
        }
    }
    public void AddItemCount(int itemPoints)
    {
        itemCount += itemPoints;
        itemText.text = itemName + ": " + itemCount + "/" + total;
    }
    public void SetItemCount(int number)
    {
        itemText.text = itemName + ": " + number + "/" + total;
        itemCount = number;
    }

}
