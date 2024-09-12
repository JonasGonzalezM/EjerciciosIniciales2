using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{

    int vidas = 10;
    float exp = 100;
    float producto;
    float cociente;
    float resto;
    float dobleVidas;
    float tripleExp;


    // Start is called before the first frame update
    void Start()
    {
        producto= vidas * exp;
        cociente = vidas / exp;
        resto = vidas % exp;
        dobleVidas = vidas * 2;
        tripleExp = exp * 3;
        Debug.Log("Multiplicacion = "+ producto);
        Debug.Log("Cociente = "+ cociente);
        Debug.Log("Resto = "+ resto);
        Debug.Log("Vida Doble = "+ dobleVidas);
        Debug.Log("EXP triple = "+ tripleExp);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
