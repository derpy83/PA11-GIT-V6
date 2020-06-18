using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject SpawnObject,SpawnObject2 ,SpawnObject3, spawnobj4;
    float PositionY;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
        InvokeRepeating("SpawnObjects2", 1, 1);
        InvokeRepeating("SpawnObjects3", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {


    }

  
    void SpawnObjects()
    {
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        int i = Random.Range(1, 10);
        GameObject obj;
        if (i > 7)
        {
            obj = SpawnObject;
        }
        else if (i > 4)
        {
            obj = SpawnObject2;
        }
        else if (i > 2)
        {
            obj = SpawnObject3;
        }
        else
        {
            obj = spawnobj4;
        }
        Instantiate(obj, transform.position, transform.rotation);
    }

}
