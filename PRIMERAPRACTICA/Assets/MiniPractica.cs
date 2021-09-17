using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniPractica : MonoBehaviour
{
    //Ejercicio 2c
    int myInt = 1;

    // Start is called before the first frame update
    void Start()
    { while (myInt <= 10)
        {
            if (myInt < 5)
            {
                print("el numero es menor que 5");
            }
            else if (myInt >= 5 && myInt <= 10)
            {
                print("el numero es:" + myInt);
            }
            else
            {
                print("el numero es 10");
            }
            myInt++;
        }


    }

    // Update is called once per frame
    void Update()
    {
      

    }

   
   




}
