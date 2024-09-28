using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_10 : MonoBehaviour
{
    [SerializeField] private int numMenor;
    [SerializeField] private int numMayor=40;
    [SerializeField] private int resultado;
    // Start is called before the first frame update
    void Start()
    {
        while (numMenor <= numMayor)
        {
            numMenor++;
            resultado = numMenor + 1;
            if (resultado > 0)
            {
                Debug.Log(resultado + " el numero es positivo");
            }
            else
            {
                Debug.Log(resultado + " el numero es negativo");
            }
            
            
            if(resultado%2==0)
            {
                Debug.Log(resultado + " el numero es par");
            }
            else
            {
                Debug.Log(resultado + " el numero es impar");
            }

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
