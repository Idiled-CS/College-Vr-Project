using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMyAnimation : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player"))
        {
            myAnimationController.SetBool("playSpin2", true);
        }
    }
    private void OnTriggerExit(Collider other){
        if(other.CompareTag("Player"))
        {
            myAnimationController.SetBool("playSpin2", false);
        }
    }
}
