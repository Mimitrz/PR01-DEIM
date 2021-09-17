using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniPractica : MonoBehaviour
{
    //Ejercicio 2c

    public int myInt = 5;
    

    // Start is called before the first frame update
    void Start()
    {

        if (myInt != 10)
        {
            Debug.Log("es distinto de 5");
        }
        else if (myInt < 10)
        {
            Debug.Log("es menor que 10");
        }
        else
        {
            Debug.Log("ninguna de las opciones anteriores");
        }



    }

    // Update is called once per frame
    void Update()
    {
      

    }
}
