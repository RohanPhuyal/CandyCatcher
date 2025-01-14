using System.Collections;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    [SerializeField]
    float maxX;

    [SerializeField]
    GameObject[] candies;

    [SerializeField]
    float spawnInterval;

    public static CandySpawner instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //SpawnCandy();
        StartSpawningCandies();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnCandy()
    {
        int rand = Random.Range(0,candies.Length);

        float randomX = Random.Range(-maxX, maxX);
        Vector3 randomPos = new Vector3(randomX,transform.position.y,transform.position.z);

        Instantiate(candies[rand], randomPos, transform.rotation);
    }

    IEnumerator SpawnCandies()
    {
        yield return new WaitForSeconds(2f);

        while (true)
        {
            SpawnCandy();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    public void StartSpawningCandies()
    {
        StartCoroutine("SpawnCandies");
    }

    public void StopSpawningCandies()
    {
        StopCoroutine("SpawnCandies");
    }

}
