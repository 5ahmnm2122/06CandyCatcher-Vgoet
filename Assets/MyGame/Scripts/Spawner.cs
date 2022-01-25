using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] candy;
    public GameObject badCandy;

    public float xBounds, yBound;


    void Start()
    {
        StartCoroutine(SpawnCandies());
    }

 

    IEnumerator SpawnCandies()
    {
        yield return new WaitForSeconds(Random.Range(1, 2));

        int randomCandy = Random.Range(0, candy.Length);

        if (Random.value <= .6f)
        {
            Instantiate(candy[randomCandy],
                new Vector3(Random.Range( -xBounds, xBounds), yBound), Quaternion.identity);

        }

        else
        {
            Instantiate(badCandy,
                new Vector3(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);
        }

        StartCoroutine(SpawnCandies());
       
    }

    
}
