using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniPractica : MonoBehaviour
{
    //Ejercicio 2d

    public int aleatorio;
    int fail;

    // Start is called before the first frame update
    void Start()
    {

      /* for(int myInt=0; myInt<10; myInt++)
        {
            aleatorio = Random.Range(0, 10);
            
        }
      */
       while (aleatorio != 2)
        {
            aleatorio = Random.Range(0, 10);
        
            if (aleatorio == 2)
            {
                print("ha llegado a:" + aleatorio);
                print("ha fallado:" + fail);
            }
            else
            {
                fail++;
            }
        }
       

    }

    // Update is called once per frame
    void Update()
    {
      

    }
}
