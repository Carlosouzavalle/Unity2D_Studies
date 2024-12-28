using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variavel : MonoBehaviour
{
    int vidas = 3;
    string nome = "Carlos";
    float velocidade = 1.5f;



    void Start()
    {
        Debug.Log(vidas);
        Debug.Log(nome);
        Debug.Log(velocidade);
    }

    
    void Update()
    {
        
    }
}


/*
O problema no seu código está na linha onde você declara a variável nome. Em C#, uma string deve 
ser delimitada por aspas duplas (") e não por apóstrofos ('). Os apóstrofos são usados apenas para caracteres (char).
Além disso, em números decimais (float), é necessário adicionar o sufixo f no final para indicar que o número é um float.


o c# tem alguns tipos muito especificos interessantes double, char

Double é usado para representar números de ponto flutuante (decimais) com maior precisão em comparação ao tipo float.
É ideal para cálculos onde precisão é importante, como em operações matemáticas avançadas.


O tipo char em C# é usado para armazenar um único caractere. 
Ele é delimitado por apóstrofos ('), ao contrário de strings, que usam aspas duplas (").




*/