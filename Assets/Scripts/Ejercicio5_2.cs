using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_2 : MonoBehaviour
{
    [SerializeField] private int numero1 = 4;
    [SerializeField]private int numero2 = 7;
    // Start is called before the first frame update
    void Start()
    {
        if (numero1 <= 3)
        {
            Debug.Log(" El Numero1 es menor a 3,que bacano");
        }
        else
        {
            Debug.Log("El Numero1 no es menor a 3 mu mal ");
        }


        if (numero2 <= 3)
        {
            Debug.Log("El Numero2 es menor a 3 mu bien ");

        }
        else
        {
            Debug.Log("El Numero2 no es menor a 3 mu mal ");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
