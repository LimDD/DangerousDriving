using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroid : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public GameObject carCordinate;
    public float spawnTimer = 0.7f;
    public Vector3 positionOfCar;
    void Start()
    {
        StartCoroutine(asteroidLoop());
        
    }
    void Update()
    {
        this.positionOfCar = carCordinate.transform.position;
    }
    private void spawner()
    {
        for (int i = 0; i < 4; i++)
        {
            GameObject aster = Instantiate(asteroidPrefab) as GameObject;
            aster.transform.position = new Vector3(this.positionOfCar.x + Random.Range(-50, 50), 60, this.positionOfCar.z + Random.Range(-50, 50));
        }
        }
    IEnumerator asteroidLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTimer);
            spawner();
        }
    }
}
