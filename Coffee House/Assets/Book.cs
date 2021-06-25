using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    public Material BookPage;
    int index;
    public Texture[] Zas;
    // Start is called before the first frame update
    void Start()
    {
        BookPage.SetTexture("_MainTex",Zas[index]);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            index++;
            BookPage.SetTexture("_MainTex",Zas[index]);
        }
        if(Input.GetKeyDown(KeyCode.Q))
        {
            index--;
            BookPage.SetTexture("_MainTex",Zas[index]);
        }
    }
}
