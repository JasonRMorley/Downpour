using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    int rand;
    public GameObject enemy;
    public Transform[] spawnPoints;//Array that holds the spawnpoints added in unity engine
                                   
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Spawn(int lane){
        
        GameObject go = Instantiate(enemy, new Vector3(10,spawnPoints[lane].transform.position.y+(Random.Range(-0.4f,0.4f))), Quaternion.identity) as GameObject;
    }
}


