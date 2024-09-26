using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_10 : MonoBehaviour
{
    [SerializeField] private int temp = 12;
    // Start is called before the first frame update
    void Start()
    {
        if(temp<=10)
        {
            Debug.Log("Hace Frio");
        }
        else if (10 < temp && temp <= 20)
        {
            Debug.Log("Está nublado");
        }
        else if (20 < temp && temp <= 30)
        {
            Debug.Log("Hace un poco de calor");
        }
        else if (temp > 30)
        {

            Debug.Log("Hace un clima tropical");
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
