using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomDotsSpawner : MonoBehaviour
{
    public Vector2[] positions = new Vector2[4];
    public GameObject[] dots = new GameObject[4];
    public float spawnTime;
    private float timeToSpawn; 
    // Start is called before the first frame update
    void Start()
    {
        timeToSpawn = spawnTime;
    }
    // Update is called once per frame
    void Update()
    {
        if(timeToSpawn<=0)
        {
            int randomItem = Random.Range(0,4);
            Instantiate(dots[randomItem],positions[randomItem],new Quaternion(0,0,0,0));
            timeToSpawn=spawnTime;
        }else
        {
            timeToSpawn-=Time.deltaTime;
        }
    }
}
