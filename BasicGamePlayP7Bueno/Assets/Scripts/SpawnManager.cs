using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;


    // Start is called before the first frame update

    private float startDelay = 2f;
    private float spawnInterval = 1.5f;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }
    private float spawnRangeX = 20;
    private float spawnPosZ = 20f;

    // Update is called once per frame
    void Update()
    {
       
       
    }
    // Randomly generate animal Index and spawn position 
    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),
            0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
    }
}
