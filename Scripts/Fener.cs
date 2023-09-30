using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fener : MonoBehaviour
{
    public Transform player;
    public GameObject fener;
    public bool dugme;
    public GameObject yanardoner;
    public bool mesafe = false;
    bool yazi = true;
    public GameObject text1;
    // public GameObject text1;


    // Update is called once per frame
    void Update()
    {
        fenerIcin();
        fenerAcma();
    }

    public void fenerAcma()
    {
        if (GameObject.FindGameObjectWithTag("isik").GetComponent<MeshRenderer>().enabled)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                dugme = !dugme;

            }

            if (dugme)
            {
                GameObject.FindGameObjectWithTag("light").GetComponentInChildren<Light>().enabled = true;
            }

            if (!dugme)
            {
                GameObject.FindGameObjectWithTag("light").GetComponentInChildren<Light>().enabled = false;
            }

        }

    }

    public void fenerIcin()
    {
        if (Vector3.Distance(fener.transform.position, player.position) < 3 && yazi == true)
        {
            mesafe = true;
            text1.SetActive(true);
        }

        else
        {
            mesafe = false;
            text1.SetActive(false);
        }

        if (mesafe == true && Input.GetKey(KeyCode.E))
        {
            text1.SetActive(false);
            transform.parent = GameObject.Find("FPSController").GetComponent<OyuncuKontrol>().solEl;
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            yanardoner.SetActive(false);
            yazi = false;
        }
    }

}