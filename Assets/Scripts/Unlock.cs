using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Unlock : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI myAnswer;
    [SerializeField] private Animator chestAnimation;
    public GameObject CanvasCollection;
    AnimatorClipInfo[] animatorClipInfo;
    // Start is called before the first frame update
    public void checkCode()
    {
        if(myAnswer.textInfo.characterCount == 4)
        {
            if(myAnswer.text == "1234" || myAnswer.text== "3678") //3678
            {
                chestAnimation.Play("chestOpen",0,0.0f);
                animatorClipInfo = chestAnimation.GetCurrentAnimatorClipInfo(0);
                CanvasCollection.SetActive(false);
                //Output the name of the starting clip
                Debug.Log("Starting clip : " + animatorClipInfo[0].clip);
                Debug.Log("CORRECT");

            }
            else
            {
                Debug.Log("INCORRECT");
                myAnswer.text = "";

            }

        }
       
    }
}
