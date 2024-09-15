using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{
    public int baseTri = 6;
    public int alturaTri = 9;
    
    // Start is called before the first frame update
    void Start()
    {
        float areaTri = (baseTri * alturaTri) / 2;
        Debug.Log("El área del area de deteccion " + areaTri);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
