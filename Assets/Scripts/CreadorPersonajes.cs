using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorPersonajes : MonoBehaviour
{
    
    float num = 3.4f;
    //[SerializeField] Personaje link= null;// null es nada, es como si fuese valor nulo, 0.
    //[SerializeField] GameObject mario;
    [SerializeField] Personaje link;
    [SerializeField] Personaje mario;
     
     
     
     
    // Start is called before the first frame update
    void Start()
    {

        //link´s life
        link.Vida = 100;
        link.Velocidad = 50;
        link.Danho = 100;
        link.Nombre = "Alfredo";


        link.Mover(3, 0, -1);
        mario.Mover(3, 0, -1);


        transform.Rotate(new Vector3(9, 8, 1));

        



    }

}
