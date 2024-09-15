using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_4 : MonoBehaviour
{
    
    public int experiencia = 60; 
    // Start is called before the first frame update
    void Start()
    {
        float nivelPersonaje = 32 + (9 * experiencia / 5);
        Debug.Log("Nivel personaje es "+ nivelPersonaje);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
