using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_13 : MonoBehaviour
{
    [SerializeField] private int numero;
    [SerializeField] private bool primo;
    // Start is called before the first frame update
    void Start()
    {
        while(numero>=0)
        {
            if (numero / 1 == 0)
            {
                primo = true;
                Debug.Log("el numero es primo");
                
            }
            else
            {
                primo=false;
                Debug.Log("el numero no es primo");

            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
