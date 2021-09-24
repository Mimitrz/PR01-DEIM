using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniPractica : MonoBehaviour
{
    //Ejercicio 4b

    [SerializeField]float speed;
    Vector3 DestPos;

    // Start is called before the first frame update
    void Start()
    {
        
     

    }

    // Update is called once per frame
    void Update()
    {


        float desplX = Input.GetAxis("Horizontal")* speed;
        transform.Translate(Vector3.right * desplX * Time.deltaTime);
        float desplY = Input.GetAxis("Vertical") * speed;
        transform.Translate(Vector3.up * desplY * Time.deltaTime);
        float desplZ = Input.GetAxis("Mouse X") * speed;
        transform.Translate(Vector3.forward * desplZ * Time.deltaTime);
        float desplZ2 = Input.GetAxis("Mouse Y") * speed;
        transform.Translate(Vector3.back * desplZ2 * Time.deltaTime);

    }



}


