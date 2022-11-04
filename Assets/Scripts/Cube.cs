using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float speedCube;
    public float distanceCube;
    public Vector3 startPositionCube;
    public GameObject effectDieCube;


    void Start()
    {
        
    }

    void Update()
    {
        MoveCube();
    }

    public void MoveCube()
    {
        this.transform.position = this.transform.position + this.transform.rotation * new Vector3(1, 0, 0) * speedCube * Time.deltaTime;
        float distance = Vector3.Distance(startPositionCube, this.transform.position);

        if (distance >= distanceCube)
        {
            Instantiate(effectDieCube, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }

    public void Init(float speed, float distance)
    {
        speedCube = speed;
        distanceCube = distance;

    }
}
