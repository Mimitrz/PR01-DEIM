using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniPractica : MonoBehaviour
{
    //Ejercicio 2a
    public int myInt = 10;
    

    // Start is called before the first frame update
    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {
        while (myInt < 20)
        { 
            myInt++;
            print(myInt);

        }

    }
}
