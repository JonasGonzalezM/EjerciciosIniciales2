using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_1 : MonoBehaviour
{

   [SerializeField] private int vidaPLayer1 = 3;
   [SerializeField] private int vidaPLayer2 = 3;

    // Start is called before the first frame update
    void Start()
    {
        if (vidaPLayer1 == vidaPLayer2)
        {
            Debug.Log("La vida es la misma, la pelea será reñida");
        }
        if (vidaPLayer1 != vidaPLayer2)
        {
            Debug.Log("La vida no es la misma, la pelea esta desbalanceada, Bienvenido a Dark Souls");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
