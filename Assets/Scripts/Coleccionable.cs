using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coleccionable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles=new Vector3(45, 45,45);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,3,0)*6*Time.deltaTime);
    }
}
