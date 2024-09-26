using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_8 : MonoBehaviour
{
    [SerializeField] private int hora = 12;
    [SerializeField] private int minutos = 30;
    [SerializeField] private int segundos = 45;
    // Start is called before the first frame update
    void Start()
    {
        if(hora<=24 && segundos<=60 && minutos <= 60)
        {
            Debug.Log("Tu hora está escrito de manera adecuada, son la/las " + hora+":"+minutos+":"+segundos);
        }
        else if(hora<0 && segundos<0 && minutos < 0)
        {
            Debug.Log("La hora está mal escrita, escribela de la manera adecuada ");

        }
        else
        {
            Debug.Log("La hora está mal escrita, escribela de la manera adecuada ");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
