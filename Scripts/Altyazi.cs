using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Altyazi : MonoBehaviour
{
    public GameObject text0;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject text6;
    public GameObject text7;
    public GameObject text8;
    public GameObject text9;

    // Update is called once per frame
    void Start()
    {
        Invoke("Text0ac", 2);
        Invoke("Text0kapa", 5);

        Invoke("Text1ac", 6);
        Invoke("Text1kapa", 9);

        Invoke("Text2ac", 10);
        Invoke("Text2kapa", 13);

        Invoke("Text3ac", 14);
        Invoke("Text3kapa", 17);

        Invoke("Text4ac", 18);
        Invoke("Text4kapa", 21);

        Invoke("Text5ac", 22);
        Invoke("Text5kapa", 27);

        Invoke("Text6ac", 28);
        Invoke("Text6kapa", 33);

        Invoke("Text7ac", 34);
        Invoke("Text7kapa", 39);

        Invoke("Text8ac", 40);
        Invoke("Text8kapa", 45);

        Invoke("Text9ac", 46);
        Invoke("Text9kapa", 51);
    }

    void Text0ac()
    {
        text0.SetActive(true);
    }
    void Text0kapa()
    {
        text0.SetActive(false);
    }
    void Text1ac()
    {
        text1.SetActive(true);
    }
    void Text1kapa()
    {
        text1.SetActive(false);
    }
    void Text2ac()
    {
        text2.SetActive(true);
    }
    void Text2kapa()
    {
        text2.SetActive(false);
    }
    void Text3ac()
    {
        text3.SetActive(true);
    }
    void Text3kapa()
    {
        text3.SetActive(false);
    }
    void Text4ac()
    {
        text4.SetActive(true);
    }
    void Text4kapa()
    {
        text4.SetActive(false);
    }
    void Text5ac()
    {
        text5.SetActive(true);
    }
    void Text5kapa()
    {
        text5.SetActive(false);
    }

    void Text6ac()
    {
        text6.SetActive(true);
    }
    void Text6kapa()
    {
        text6.SetActive(false);
    }
    void Text7ac()
    {
        text7.SetActive(true);
    }
    void Text7kapa()
    {
        text7.SetActive(false);
    }
    void Text8ac()
    {
        text8.SetActive(true);
    }
    void Text8kapa()
    {
        text8.SetActive(false);
    }
    void Text9ac()
    {
        text9.SetActive(true);
    }
    void Text9kapa()
    {
        text9.SetActive(false);
    }


}
