using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerCollision : MonoBehaviour
{
    CharacterController m_CharacterController;

    // Start is called before the first frame update
    void Start()
    {
        m_CharacterController = GetComponent<CharacterController>();
        m_CharacterController.detectCollisions = true;
        Debug.Log("entered");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("Collision de " + this.transform.name + " avec " + hit.collider.name + " (OnControllerColliderHit)");

    }
}
