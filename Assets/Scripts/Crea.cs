using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crea : MonoBehaviour
{
    [SerializeField] private Animator Gate_open;
    [SerializeField] private GameObject key;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("SELCTION STARTED");
    }

    // Update is called once per frame
    public void SelectMe()
    {
        //GameObject.Destroy(key);
        Gate_open.Play("Gate_Right", 0, 0.0f);
        Debug.Log("Door SELECTED");

    }
}
