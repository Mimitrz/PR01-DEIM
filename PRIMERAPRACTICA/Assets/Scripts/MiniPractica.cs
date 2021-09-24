using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniPractica : MonoBehaviour
{
    //Ejercicio 3b

    [SerializeField] int n1;
    [SerializeField] int n2;

    bool devolver;   //Variable booleana para devolver el resultado
    int Resultadofinal; 

    // Start is called before the first frame update
    void Start()
    {

        Matematica();

    }

    // Update is called once per frame
    void Update()
    {
      

    }

    void Matematica()
    {

        Resultadofinal = n1 + n2;  
        if (Resultadofinal<=5)
        {

            devolver = true;

        }
        else
        {
            devolver = false;
        }

        print("El resultado es: " + devolver);
       
        return;

    }






    }
