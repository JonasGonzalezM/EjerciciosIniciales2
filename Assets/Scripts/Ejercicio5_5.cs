using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_5 : MonoBehaviour
{
    [SerializeField] private int numero = 5;

    // Start is called before the first frame update
    void Start()
    {
        if (numero % 2 == 0)
        {
            Debug.Log("El numero es par");
        }
        else
        {
            Debug.Log("El numero es Impar");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
