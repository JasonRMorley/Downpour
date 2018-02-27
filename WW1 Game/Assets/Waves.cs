using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waves : MonoBehaviour {
    public float timer;
    public float spawnTime = 1;
    public GameObject Spawner;
    public int currentWave;
    public int lanesNeeded;
    public int enemiesThisRound;
    public int[] enemiesInWave;
    int enemiesSpawned = 0;

    
    // Use this for initialization
    void Start ()
    {
       
         StartCoroutine(SpawnWave());
        
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        //timer += Time.deltaTime;
       
        

    }

    IEnumerator SpawnWave()
    {
        if (enemiesSpawned < enemiesInWave[currentWave])
        {
            
            Spawner.GetComponent<EnemySpawner>().Spawn(Random.Range(0, 5));
            enemiesSpawned++;
        }
        yield return new WaitForSeconds(spawnTime);
        if(enemiesSpawned < enemiesInWave[currentWave])
        {
            StartCoroutine(SpawnWave());
        }

    }
}
