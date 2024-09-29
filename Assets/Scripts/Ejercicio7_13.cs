using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_13 : MonoBehaviour
{
    [SerializeField] private int numero=29;
    //[SerializeField] private int resultado;
    //[SerializeField] private bool primo=true;
    // Start is called before the first frame update
    void Start()
    {

        int numero = 29; // Cambia este número para probar
        bool esPrimo = EsPrimo(numero);
        Debug.Log($"{numero} es primo: {esPrimo}");

        //while(numero>=0&& primo ==true)
        //{
        //    resultado = numero / 1;
        //    if (resultado == 0)
        //    {
        //        Debug.Log("el numero es primo");
        //        primo = true;

        //    }

        //    if(resultado!=0)
        //    {
        //        Debug.Log("el numero no es primo");
        //        primo=false;

        //    }
        //    break;

        //}

    }

    // Update is called once per frame
    bool EsPrimo(int numero)
    {
        if (numero < 2) return false; // Los números menores a 2 no son primos
        for (int i = 2; i * i <= numero; i++)
        {
            if (numero % i == 0) return false; // No es primo
        }
        return true; // Es primo
    }
}
