using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonDummy : MonoBehaviour
{
    public Transform[] dummyPos;
    public bool isDummy;
    public GameObject dummy;

    void Start()
    {
        isDummy = false;
    }

    void Update()
    {
        if (!isDummy)
        {
            //더미 소환, isdummy true
            Instantiate(dummy, dummyPos[Random.Range(0, 4)].position, Quaternion.identity);
            isDummy = true;
        }
    }
}
