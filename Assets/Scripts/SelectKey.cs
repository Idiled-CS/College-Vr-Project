using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectKey : MonoBehaviour
{
    [SerializeField] private Animator doorAnimation;
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
        doorAnimation.Play("doorOpen", 0, 0.0f);
        Debug.Log("KEY SELECTED");

    }
}
