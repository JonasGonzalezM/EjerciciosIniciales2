using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_4 : MonoBehaviour
{
    int vidas = 60;

    // Start is called before the first frame update
    void Start()
    {
        vidas = vidas + 77;
        Debug.Log("Incremento " + vidas);
        vidas = vidas - 3;
        Debug.Log("Decrecion "+ vidas);
        vidas = vidas * 4;
        Debug.Log("Valor Total "+ vidas);


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
