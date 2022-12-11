using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateObject : MonoBehaviour
{
    [SerializeField] private Transform Spawnpoint;
    [SerializeField] private GameObject Prefab;

    private void OnTriggerEnter(Collider other)
    {
        
            Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);

    }

}


