using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{
    [SerializeField] private int numero1 = 0;
    [SerializeField]private int numero2 = 0;
    float resultado;
    // Start is called before the first frame update
    void Start()
    {
        if(numero1==0 && numero2 == 0)
        {
            Debug.Log("La division no puede realizarse ya que los divisores son 0");
        }
        else
        {
            resultado = numero1 / numero2;
            Debug.Log("El resultado es " + resultado);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
