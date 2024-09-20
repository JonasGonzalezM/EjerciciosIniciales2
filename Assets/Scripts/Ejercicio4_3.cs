using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    [SerializeField] private int dolar;
    [SerializeField] private int euro;
    [SerializeField] private string moneda;


    // Start is called before the first frame update
    void Start()
    {
        string convertirDolar = " ahora tienes "+ConvertirDolar( dolar,  euro,  moneda);
        
    }

     string ConvertirDolar(int dolar,int euro, string moneda)
    {
        float conversionDolar = euro * 0.631f;
        
    }
    
}
