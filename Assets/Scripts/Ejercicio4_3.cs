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
        string moneda = Convertir( dolar, euro, moneda);
        Debug.Log(moneda);
    }

     string Convertir(int dolar,int euro, string moneda)
    {
        string conversion ="Tienes"+ (dolar * 0.631f) + (euro * 0.631f);
        moneda = conversion;
        return moneda;
    }
    
}
