using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_7 : MonoBehaviour
{
    int oro= 7;
    int segundosHora = 3600;
    int horas = 4;

    // Start is called before the first frame update
    void Start()
    {
        int tiempo;
        tiempo = segundosHora * horas;
        int oroTotal;
        oroTotal = tiempo * oro;
        Debug.Log("El jugador farmeará un total de " + oroTotal + " en " + horas + " horas");


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
