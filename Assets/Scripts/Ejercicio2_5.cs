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
        vidaPlayer2 = vidaPlayer3;
        Debug.Log("Vida Player 2 " + vidaPlayer2);
        vidaPlayer3 = vidaPlayer1;
        Debug.Log("Vida PLayer 3 " + vidaPlayer3);
        vidaPlayer1 = vidaPlayer4;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
