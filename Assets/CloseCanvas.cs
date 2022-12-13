using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CloseCanvas : MonoBehaviour
{
    public Canvas canvas;

    public void OnPointerClick()
    {
        canvas.gameObject.SetActive(false);
    }
}