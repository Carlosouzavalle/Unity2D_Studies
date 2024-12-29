using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperadoresRelacionais : MonoBehaviour
{


    int a = 10;
    int b = 5;


    void Start()
    {

        Debug.Log(a > b);  // true
        Debug.Log(a < b);  // false
        Debug.Log(a == 10); // true
        Debug.Log(a != b); // true

    }


    void Update()
    {

    }
}
