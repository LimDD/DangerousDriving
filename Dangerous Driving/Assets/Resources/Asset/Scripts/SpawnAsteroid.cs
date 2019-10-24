using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroid : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public GameObject carCordinate;
    public GameObject carSelectObject;
    public float spawnTimer = 0.7f;
    public Vector3 positionOfCar;
    void Start()
    {
        Invoke("Setup", 1f);
    }

    void Setup()
    {
        CarSelect carSelect = carSelectObject.GetComponent<CarSelect>();

        carCordinate = carSelect.currentActiveCar;
        StartCoroutine(asteroidLoop());
    }

    void Update()
    {
        if (carCordinate != null)
        {
            this.positionOfCar = carCordinate.transform.position;
        }
    }
    private void spawner()
    {
        for (int i = 0; i < 3; i++)
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
