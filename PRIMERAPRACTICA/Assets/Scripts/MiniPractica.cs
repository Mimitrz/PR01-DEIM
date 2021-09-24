using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniPractica : MonoBehaviour
{
    //Ejercicio 3c

    [SerializeField] Text MyText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Cronometro");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) ;
        {
            StartCoroutine("Cronometro");
        }


    }

    IEnumerator Cronometro()
    {
        for (int n = 0; n <= 30; n++)
        {
            MyText.text = "Contador: " + n;
            yield return new WaitForSeconds(1f);
            if (n == 30)
            {
                StopCoroutine("Cronometro");
            }
        }



    }


}


