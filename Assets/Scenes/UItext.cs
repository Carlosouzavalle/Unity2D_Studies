using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UItext : MonoBehaviour
{
    public Text nivel;
    public Text distancia;

    int somaDistancia = 0;

    void Start()
    {
        nivel.text = "Nivel 2";
        distancia.text = "0 m";
    }

    // Update is called once per frame
    void Update()
    {
        somaDistancia++;
        distancia.text = somaDistancia + " m";
    }
}
