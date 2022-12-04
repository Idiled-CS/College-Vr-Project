using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageOpenBook : MonoBehaviour
{
    public Transform head;
    private float spawnDistance=4;
    public GameObject manager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        manager.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized  ;
        manager.transform.LookAt(new Vector3(head.position.x, manager.transform.position.y, head.position.z));
        manager.transform.forward *= -1;
    }


}
