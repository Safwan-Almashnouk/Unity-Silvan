using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject objectToSpawn;
    public void Spawn()
    {
        Instantiate(objectToSpawn);
    }
}
