using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPosition;
    private float repeatPosition;
    void Start()
    {
        startPosition = transform.position;
        repeatPosition = GetComponent<BoxCollider>().size.x/2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPosition.x - repeatPosition)
        {
            transform.position = startPosition;
        }
    }
}
