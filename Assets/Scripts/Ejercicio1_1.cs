using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_1 : MonoBehaviour
{
    string nombre = "Jonas";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola mundo!");
        Debug.Log("Este es el primer videojuego de " + nombre);
        Debug.Log("Estoy aprendiendo C#");
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ha pasado 1 frame");
        // Esto ocurre debido a que cuando se escriben las acciones el el Update, este se actualiza cada frame, lo pone justo encima.
        
    }
}
