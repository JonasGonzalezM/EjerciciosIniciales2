using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    int radio = 12;
    // Start is called before the first frame update
    void Start()
    {
        float longitudCir;
        longitudCir = 2 * 3.14f * radio;

        float areaCir;
        areaCir = 3.14f * (radio ^ 2);

        Debug.Log("El enemigo tiene un área de " + areaCir + " y una longitud de deteccion de " + longitudCir);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
