using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniPractica : MonoBehaviour
{
    //Ejercicio 1a
    private int myInt = 5;
    private float myFloat = 2.3f;
    private string myString = "hola mundo";
    private bool myBool = true;

    //Ejercicio 1b
    public int yourInt = 6;
    public float yourFloat = 3.2f;
    public string yourString = "adios mundo";
    public bool yourBool = false;

    //Ejercicio 1c
    public int num1 = 2;
    public int num2 = 3;
    public int myResult;

    public string nombre1 = "hola";
    public string nombre2 = " jeje";
    public string myResult2;


    // Start is called before the first frame update
    void Start()
    {
        //Ejercicio 1a
        print(myInt);
        print(myFloat);
        print(myString);
        print(myBool);

        //Ejercicio 1b
        print(yourInt);
        print(yourFloat);
        print(yourString);
        print(yourBool);

        //Ejercicio 1c
        myResult = num1 + num2;
        Debug.Log(myResult);

        myResult2 = nombre1 + nombre2;
        Debug.Log(myResult2);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
