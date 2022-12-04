using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeyPad : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI myAnswer;

    // Update is called once per frame
    public void Number(int number)
    {
        Debug.Log(number);
        if (myAnswer.textInfo.characterCount < 4)
        {
            myAnswer.text += number.ToString();
        }
    }
}
