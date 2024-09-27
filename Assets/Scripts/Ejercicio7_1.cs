using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_1 : MonoBehaviour
{
    [SerializeField] private int contador = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while (contador <= 101)
        {
            contador++;
            Debug.Log(contador);

        }
        
    }
}
