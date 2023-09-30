using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeykelKontrol : MonoBehaviour
{
    public Transform player;
    public GameObject heykel;
    public GameObject heykel1;
    public GameObject heykel2;
    bool h1, h2, h3 = false;
    public bool mesafe = false;
    public bool click;
    public GameObject Text;
    public GameObject Text1;
    public GameObject Text2;
    public GameObject bitisKapisi, info;

    //public bool ne2;



    // Start is called before the first frame update
    void Start()
    {
        //  ne2 = GameObject.Find("BuildersTorch_PBR_Orange").GetComponent<Fener>().feneracma;

    }

    // Update is called once per frame
    void Update()
    {
        heykelmetodu();
        heykel1metodu();
        heykel2metodu();
        if (h3 && h2 && h1)
        {
            Invoke("Wait", 3);
            // Invoke("Close", 5);
            Destroy(info, 8);
        }
    }

    private void heykelmetodu()
    {

        if (Vector3.Distance(heykel.transform.position, player.position) < 8)
        {
            mesafe = true;
        }

        else
        {
            mesafe = false;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            click = !click;
        }


        if (mesafe == true && click)
        {
            Text.SetActive(true);
            h1 = true;
            Time.timeScale = 0;
        }

        if (!click)
        {
            Text.SetActive(false);
            Time.timeScale = 1;
        }

    }
    private void heykel1metodu()
    {

        if (Vector3.Distance(heykel1.transform.position, player.position) < 8)
        {
            mesafe = true;

        }

        else
        {
            mesafe = false;

        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            click = !click;
        }


        if (mesafe == true && click)
        {
            Text1.SetActive(true);
            h2 = true;
            Time.timeScale = 0;
        }

        if (!click)
        {
            Text1.SetActive(false);
            Time.timeScale = 1;

        }

    }
    private void heykel2metodu()
    {
        if (Vector3.Distance(heykel2.transform.position, player.position) < 8)
        {
            mesafe = true;
        }

        else
        {
            mesafe = false;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            click = !click;
        }


        if (mesafe == true && click)
        {
            Text2.SetActive(true);
            h3 = true;
            Time.timeScale = 0;

        }

        if (!click)
        {
            Text2.SetActive(false);
            Time.timeScale = 1;

        }

    }

    public void Wait()
    {
        info.SetActive(true);
    }
    public void Close()
    {
        info.SetActive(false);
    }

    //private void OnTriggerEnter(Collider heykel)
    //{
    //    if (heykel.CompareTag("isiktopu"))
    //    {
    //        Debug.Log("çarpiþma oldu");
    //        Text.SetActive(true);
    //    }
    //}

    //private void OnTriggerExit(Collider heykel)
    //{
    //    if (heykel.CompareTag("isiktopu"))
    //    {
    //        Debug.Log("çarpiþma bitti");
    //        Text.SetActive(false);
    //    }
    //}
}
