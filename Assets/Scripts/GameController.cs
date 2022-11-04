using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject prefabCube;
    public float timeSpawnCube;

    
    void Start()
    {
        SpawnCube();
    }

    
    void Update()
    {
        SaveTimeCube();
        timeSpawnCube -= Time.deltaTime;
        SpawnTimeCube();           
    }

    public void SpawnCube()
    {
        GameObject newCube = Instantiate(prefabCube);
        newCube.transform.position = newCube.transform.position + new Vector3(0, 1, 0);
        newCube.GetComponent<Cube>().startPositionCube = newCube.transform.position;
        newCube.GetComponent<Cube>().Init(UImanager.Instance.speed_Convert, UImanager.Instance.distance_Convert);
    }

    public void SpawnTimeCube()
    {       
        if (timeSpawnCube<=0)
        {
            SpawnCube();
        }
    }

    public void SaveTimeCube()
    {
        if (timeSpawnCube <= 0)
        {
            timeSpawnCube = UImanager.Instance.time_Convert;
        }
    }


}
