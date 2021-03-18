using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HelloWorld : MonoBehaviour
{
    [SerializeField] private int number;

    private void Start()
    {
        Debug.Log("Hello World"); 
    }
}
