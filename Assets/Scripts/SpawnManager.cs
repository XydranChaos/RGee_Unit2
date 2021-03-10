using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animalPrefabs;
    private float xPosRange = 13;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 3.0f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
            

    }
    void SpawnRandomAnimal()
    {
        float randXPos = Random.Range(-xPosRange, xPosRange);
        int animalPrefabIndex = Random.Range(0, animalPrefabs.Length);

        Vector3 randPos = new Vector3(randXPos, 0, 23);
        Instantiate(animalPrefabs[animalPrefabIndex], randPos,
               animalPrefabs[animalPrefabIndex].transform.rotation);
    }
}
