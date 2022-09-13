using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(excecute());

        StartCoroutine("excecute");
        StopCoroutine("excecute");
    }

    IEnumerator excecute()
    {
        yield return new WaitForSeconds(3f);
        print("Hello World");
    }

}