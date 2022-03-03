using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;
    [SerializeField] private float spawnX = 10;
    [SerializeField] private float spawnZ = 10;
    [SerializeField] private float startDelay = 2;
    [SerializeField] private float spawnInterval = 1.5f;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);        
    }
    void SpawnRandomAnimal()
    {
        int animal = Random.Range(0, animalPrefab.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnX, spawnX), 0, spawnZ);
        Instantiate(animalPrefab[animal], spawnPos, animalPrefab[animal].transform.rotation);
    }
}