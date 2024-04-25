using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Mathematics;
using UnityEngine;
using Random=UnityEngine.Random;

public class PipeCreatorScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    public float spawnRate = 2;
    public float timer = 0;
    public float pipeHeightOffset = 10;

    void Start()
    {
        PipeCreator();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            PipeCreator();
            timer = 0;
        }
    }

    void PipeCreator()
    {
        float lowest = transform.position.y - pipeHeightOffset;
        float highest = transform.position.y + pipeHeightOffset;
        float newHeight = Random.Range(lowest, highest);

        Instantiate(pipe, new Vector3(transform.position.x, newHeight, 0), transform.rotation);
    }
}
