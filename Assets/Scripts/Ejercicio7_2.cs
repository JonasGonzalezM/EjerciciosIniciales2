using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ejercicio7_2 : MonoBehaviour
{
    [SerializeField] private int contador;
    // Start is called before the first frame update
    void Start()
    {
        for (int contador = 0; contador < 101; contador++)
        {
            Debug.Log(contador);
            //if (contador == 101)
            //{
            //    contador = 0;
            //    break;
            //}

        }
        //return;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
