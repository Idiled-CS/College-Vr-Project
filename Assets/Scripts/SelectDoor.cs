using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDoor : MonoBehaviour
{
    [SerializeField] private Animator Door_open;
    [SerializeField] private GameObject key;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("SELCTION STARTED");
    }

    // Update is called once per frame
    public void SelectMe()
    {
        GameObject.Destroy(key);
        Door_open.Play("Door_Open", 0, 0.0f);
        Debug.Log("Door SELECTED");

    }

}
