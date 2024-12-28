using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperadoresDeAtribuicao : MonoBehaviour
{

    int pontos = 10;

    void Start()
    {
        Debug.Log("Pontos iniciais: " + pontos);

        pontos += 5; // add 5 pontos
        Debug.Log("Seus Pontos agora são: " + pontos);

        pontos -= 6; // subtrai 6 pontos
        Debug.Log("Seus pontos agora são: " + pontos);

        pontos *= 10; // multiplica 10 pontos
        Debug.Log("Seus pontos agora são: " + pontos);

        pontos /= 2; // divide por 2 pontos
        Debug.Log("Seus pontos agora são: " + pontos);

        pontos %= 6; // resto da divisao
        Debug.Log("Seus pontos agora são: " + pontos);


    }


    void Update()
    {

    }
}
