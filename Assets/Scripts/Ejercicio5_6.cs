using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_6 : MonoBehaviour
{
    [SerializeField] private int numero1 = 4;
    [SerializeField] private int numero2 = 10;
    float resultado;
    // Start is called before the first frame update
    void Start()
    {
        resultado= numero1 % numero2;

        if(resultado== 0) 
        {
            Debug.Log("El numero1 es multiplo de " + numero2);
        }
        else
        {
            Debug.Log("El numero1 no es multiplo de 10");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
