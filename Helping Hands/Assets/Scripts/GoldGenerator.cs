using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldGenerator : MonoBehaviour { 

    public ObjectPooler goldPool;

    public float distanceBetweenGold;


    public void SpawnGold (Vector3 startPos)
    {

        GameObject gold1 = goldPool.GetPooledObject();
        gold1.transform.position = startPos;
        gold1.SetActive(true);

    }


}
