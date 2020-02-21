using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightningThun : MonoBehaviour {

    public GameObject lightningThunda,thundaSpawn;
    private float timer = 0;
    private bool startDeath = false;
    private float deathTimer = 3f;
    private float randomSpawnDelay = 0;
    private float randomSpawnTimer = 0;
    GameObject thunda;

    // Use this for initialization
    void Start () {
        randomSpawnDelay = Random.Range(10f, 20f);
        //spawnLighting();
	}
	
	// Update is called once per frame
	void Update () {
        if (randomSpawnTimer == 0 || randomSpawnTimer >= randomSpawnDelay)
        {
            spawnLighting();
            randomSpawnTimer -= randomSpawnDelay;
        }
        randomSpawnTimer += Time.deltaTime;

        if (startDeath)
        {
            timer += Time.deltaTime;
        }
        else
            timer = 0;

        if (deathTimer <= timer)
        {
            Destroy(thunda);
            startDeath = false;
        }
	}


    public void spawnLighting()
    {
        thunda = Instantiate(lightningThunda, thundaSpawn.transform.position, thundaSpawn.transform.rotation);
        thunda.transform.localScale = thundaSpawn.transform.localScale;
        startDeath = true;

       // StartCoroutine("destroyThunda",thunda);

    }
    IEnumerable destroyThunda(GameObject thund)
    {
        yield return new WaitForSecondsRealtime(3);
        Destroy(thund);
    }
}
