using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coleccionable : MonoBehaviour
{
    [SerializeField] private int velocidad = 90;
    [SerializeField] Vector3 velocidadVector = new Vector3(0,1,0);
    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles=new Vector3(45, 45,45);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(velocidadVector * velocidad *Time.deltaTime,Space.World);
        //Las variabes 
    }
}
