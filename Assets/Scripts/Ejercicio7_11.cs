using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_11 : MonoBehaviour
{
    [SerializeField] private int numero= 3;
    [SerializeField] private int numMulti=1;
    [SerializeField] private int resultado;
    // Start is called before the first frame update
    void Start()
    {
        while(numMulti<=10)
        {
            resultado = numero * numMulti;
            numMulti++;
            Debug.Log(numero+" * "+numMulti+" = "+resultado);
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
