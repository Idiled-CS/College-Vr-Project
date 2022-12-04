using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLock : MonoBehaviour
{
    public GameObject lockPad;
    private bool lockOn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showLockUI()
    {
        lockOn = lockPad.activeSelf;
        lockPad.SetActive(!lockOn);

        Debug.Log("SHOW UI FOR LOCK");
    }
}
