using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_9 : MonoBehaviour
{
    [SerializeField] private int contador;
    // Start is called before the first frame update
    void Start()
    {
        for (int contador = 0; contador < 30;contador++)
        {
            if (contador % 3 == 0)
            {
                contador++;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
