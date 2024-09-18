using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    [SerializeField] private string nombre = "Jonas ";
    [SerializeField] private string apellido1 = "Gonzalez ";
    [SerializeField] private string apellido2 = "Moreno ";
    [SerializeField] private int edad = 23;
    // Start is called before the first frame update
    void Start()
    {
       string saludoCompleto= CrearNombre(nombre, apellido1, apellido2, edad);
        Debug.Log(saludoCompleto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    string CrearNombre(string nombre,string apellido1, string apellido2, int edad)
    {
        string saludoCompleto = nombre + apellido1+apellido2+edad;
        return  saludoCompleto;
    }

}
