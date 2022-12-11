using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portal : MonoBehaviour
{
    public string LevelName;

    void Start()
    {
        
    }

    void GoToScene()
    {
        SceneManager.LoadScene(LevelName);
    }
    
}
