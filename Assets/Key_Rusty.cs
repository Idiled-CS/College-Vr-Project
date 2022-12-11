using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Rusty : MonoBehaviour
{
    [SerializeField] private KeyType keyType;
    public enum KeyType {
        Rusty_Key,
        Silver_Key,
    }

}
