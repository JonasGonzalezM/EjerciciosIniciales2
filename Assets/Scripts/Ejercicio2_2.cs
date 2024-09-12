using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vidas = 10;
    float exp = 100;
    char carac= 'H';
    float resultadoSuma;
    float resultadoResta;


    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("vidas "+vidas);
        Debug.Log("Exp "+exp);
       
        resultadoSuma= vidas + exp;
        resultadoResta = exp - vidas;
        
        
        Debug.Log("Exp + Vidas "+resultadoSuma);
        Debug.Log("Exp - Vidas "+resultadoResta);
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
