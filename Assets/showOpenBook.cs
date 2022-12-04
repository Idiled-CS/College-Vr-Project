using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showOpenBook : MonoBehaviour
{
    public GameObject book;
    public GameObject bookManager;
    public GameObject canvasItem;
    public GameObject obj1;
    public GameObject obj2;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void TurnOnInspection()
    {
        bookManager.SetActive(true);
        canvasItem.SetActive(true);

    }

    public void TurnOffInspection() {
        Debug.Log("INSIDE TURN OFF");   
        bookManager.SetActive(false);
        obj1.SetActive(false);
        obj2.SetActive(false);

    }

    // Update is called once per frame

}
