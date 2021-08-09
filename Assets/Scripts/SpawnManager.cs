using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    //public int animalIndex;

    private float spawnRangeX = 9f;
    private float spawnRangeZDown = 5f;
    private float spawnRangeZUp = 17f;

    private float spawnPosZ = 20f;
    private float spawnPosX = 23f;

    private float startDelay = 2;
    private float spawnInterval = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRadomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnRadomAnimal()
    {
        
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 rotationLeft = new Vector3(0, 90, 0);
        Vector3 rotationRight = new Vector3(0, -90, 0);

        Vector3 spawnPosUp = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Vector3 spawnPosLeft = new Vector3(-spawnPosX, 0, Random.Range(spawnRangeZDown, spawnRangeZUp));
        Vector3 spawnPosRight = new Vector3(spawnPosX, 0, Random.Range(spawnRangeZDown, spawnRangeZUp));
        
        Instantiate(animalPrefabs[animalIndex], spawnPosUp, animalPrefabs[animalIndex].transform.rotation);
        Instantiate(animalPrefabs[animalIndex], spawnPosLeft, Quaternion.Euler(rotationLeft));
        Instantiate(animalPrefabs[animalIndex], spawnPosRight, Quaternion.Euler(rotationRight));
        
    }
}
