using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

//Fist Full of Shrimp Part 3
public class InputReader : MonoBehaviour
{
    List<InputDevice> inputDevices = new List<InputDevice>();
    // Start is called before the first frame update
    void Start()
    {
        print("Hi");
        InitializeInputReader();
    }

    // Update is called once per frame
    void Update()
    {
 
        if (inputDevices.Count < 2)
        {
            InitializeInputReader();
        }
    }

    void InitializeInputReader()
    {
        InputDevices.GetDevices(inputDevices);

        foreach(var inputDevice in inputDevices)
        {
            print("Hi");
            Debug.Log("***"+inputDevice.name + " " + inputDevice.characteristics);
        }
    }
}
