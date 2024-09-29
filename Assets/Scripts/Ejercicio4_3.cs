using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    [SerializeField] private int dolar;
    [SerializeField] private int euro;
    [SerializeField] private string moneda;
    [SerializeField] private string monedaDolar;


    // Start is called before the first frame update
    void Start()
    {
        string moneda = ConvertirEuros(euro);
        Debug.Log(moneda);


        string monedaDolar = ConvertirDolares(dolar);
        Debug.Log(monedaDolar);
    }

     string ConvertirEuros(int euro)
    {
        //string conversion ="Tienes "+ (dolar * 0.631f) + (euro * 0.631f);
        //moneda = conversion;
        //return moneda;
        float diferencia = euro * 0.1f;
        string resultadoDolares ="Tienes "+ (euro + diferencia) + " dolares tras pasar de euros a dolares";
        return resultadoDolares;


    }


    string ConvertirDolares(int dolar)
    {
        float diferencia= dolar * 0.1f;
        string resultadoEuro="Tienes "+(dolar-diferencia)+ " euros tras pasar de dolar a euro";
        return resultadoEuro;
    }
    
}
