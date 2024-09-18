using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    int radioCir = 4;
    int baseTri = 6;
    int alturaTri = 5;
    int ladoCuadr = 4;
    float areaCir;
    float areaTri;
    float areaCuadr;

    // Start is called before the first frame update
    void Start()
    {
        areaCir = (radioCir ^ 2) * 3.14f;
        Debug.Log("El área del circulo es de "+areaCir);
        areaTri = (baseTri * alturaTri) / 2;
        Debug.Log ("El area del triangulo es de "+areaTri);
        areaCuadr = ladoCuadr*ladoCuadr;
        Debug.Log ("El area del cuadrado es de "+ areaCuadr);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
