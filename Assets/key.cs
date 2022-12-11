using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    [SerializeField] private KeyType keyType;
    public enum KeyType{
        Rusty_Key,
        Silver_Key

    }
}
