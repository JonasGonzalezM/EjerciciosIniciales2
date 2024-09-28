using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_7 : MonoBehaviour
{
    [SerializeField] private int numMenor;
    [SerializeField] private int numMayor= 12;
    // Start is called before the first frame update
    void Start()
    {
        for (int numMenor = 0; numMenor < numMayor; numMenor++)
        {
            Debug.Log(numMenor);

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
