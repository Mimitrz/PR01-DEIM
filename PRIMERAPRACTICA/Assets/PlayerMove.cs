using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Vector3 cubePos = new Vector3(0f, 0f, 0f);
    public float speed = 1f;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = cubePos;  

    }

    // Update is called once per frame
    void Update()
    {
        float desplH = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * desplH);
        float desplV = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * Time.deltaTime * speed * desplV);
        float desplZ = Input.GetAxis("Profundidad");
        transform.Translate(Vector3.back * Time.deltaTime * speed * desplZ);
       

        /* Vector3 destPos = new Vector3(-1f, 1f, 0f);
         cubePos = cubePos + destPos * Time.deltaTime * speed;
         transform.position = cubePos;*/


    }
}
