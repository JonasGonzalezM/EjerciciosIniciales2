using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    
    float coraje = 35f;
    float poder = 100f;
    float magia = 20f;
    // Start is called before the first frame update
    void Start()
    {
        float valorInicial;
        float valorTotal;
        valorInicial = coraje+poder+magia;
        valorTotal = valorInicial / 3;
        Debug.Log("El jugador tiene " + coraje + " puntos de Coraje, " + poder + " puntos de Poder y " + magia + " puntos de magia y su media es de " + valorTotal);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
