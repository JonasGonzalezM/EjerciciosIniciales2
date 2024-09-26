using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_3 : MonoBehaviour
{
    [SerializeField] private int numero = 8;
    // Start is called before the first frame update
    void Start()
    {
        if(numero >=0 && numero<=9) 
        {
            Debug.Log("El numero esta entre el 0 y el 9");
        
        }
        else
        {
            Debug.Log("El numero no está entre el 0 y el 9");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
