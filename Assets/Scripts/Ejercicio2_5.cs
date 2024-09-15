using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
    int vidaPlayer1 = 35;
    int vidaPlayer2 = 25;
    int vidaPlayer3 = 50;
    int vidaPlayer4 = 80;
    // Start is called before the first frame update
    void Start()
    {
        int vidaP1= vidaPlayer1;
        int vidaP2= vidaPlayer2;
        int vidaP3= vidaPlayer3;
        int vidaP4= vidaPlayer4;
        vidaP2 = vidaPlayer3;
        Debug.Log("La vida del PLayer 2 era " + vidaPlayer2+ " ahora es "+ vidaP2);
        vidaP3 = vidaPlayer1;
        Debug.Log("La vida del PLayer 3 era " + vidaPlayer3 + " ahora es "+vidaP3);
        vidaP1 = vidaPlayer4;
        Debug.Log("La vida del PLayer 1 era "+vidaPlayer1+ " ahora es "+vidaP1);
        vidaP4 = vidaPlayer2;
        Debug.Log("La vida del PLayer 4 era "+vidaPlayer4 + " ahora es "+vidaP4);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
