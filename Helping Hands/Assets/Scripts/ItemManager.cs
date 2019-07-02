using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public Text itemText;

    public float itemCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AddItemCount(int itemPoints)
    {
        itemCount += itemPoints;
        itemText.text = "Gold: " + itemCount + "/10";
    }

}
