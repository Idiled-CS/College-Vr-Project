using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    public string sceneName;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "exitCube")
        {
            SceneManager.LoadScene(sceneName);
            print("ENTER"+ sceneName);
        }
        
    }
}
