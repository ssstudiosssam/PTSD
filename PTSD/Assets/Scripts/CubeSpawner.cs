using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{

    public GameObject[] cubes;
    private int cubeToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("LaunchCube", 2.0f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LaunchCube()
    {
        cubeToSpawn = Random.Range(1, 9);
        Debug.Log(cubeToSpawn);
        Instantiate(cubes[cubeToSpawn-1]);
    }

    public void StopCubes()
    {
        CancelInvoke();
    }
}
