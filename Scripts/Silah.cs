using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silah : MonoBehaviour
{
    public GameObject silah;
    public Transform player;
    public bool mesafe = false;
    public GameObject yanardoner2;
    public GameObject text;
    bool yazi = true;
    [SerializeField] private AudioClip popSesi;
    private AudioSource m_AudioSource;



    private void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        SilahIcin();
    
    }
    public void SilahIcin()
    {
        if (Vector3.Distance(silah.transform.position, player.position) < 3 && yazi == true )
        {
            mesafe = true;
            text.SetActive(true);
        }

        else
        {
            mesafe = false;
            text.SetActive(false);
           
        }

        if (mesafe == true && Input.GetKey(KeyCode.E) && yazi == true)
        {
            m_AudioSource.clip = popSesi;
            m_AudioSource.Play();
            text.SetActive(false);
           // Vector3.Distance(silah.transform.position, player.position) = 0;
            transform.parent = GameObject.Find("FPSController").GetComponent<OyuncuKontrol>().sagEl;
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.Euler(-90, 0, 0);
            yanardoner2.SetActive(false);
            yazi = false;
        }

    }

}
