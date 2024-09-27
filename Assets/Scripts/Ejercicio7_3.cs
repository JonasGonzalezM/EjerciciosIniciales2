using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_3 : MonoBehaviour
{
    [SerializeField] private int contador = 101;
    //[SerializeField] private bool activo = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while(contador > 0)
        {
            contador--;
            Debug.Log(contador);

        }
        
    }
}
