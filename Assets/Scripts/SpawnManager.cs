using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject enemyPrefab;
    float randomPos = 13.0f;
    float randomHeight = 6.0f;

    void SpawnEnemy()
    {
      Instantiate(enemyPrefab, new Vector2(Random.Range(-randomPos, 13.0f),Random.Range(-randomHeight, 8.5f)), Quaternion.identity);
    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1.0f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
