using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_4 : MonoBehaviour
{
    [SerializeField] private int contador;
    // Start is called before the first frame update
    void Start()
    {
        for (int contador =101; contador > 0; contador--)
        {
            Debug.Log(contador);

        }
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
