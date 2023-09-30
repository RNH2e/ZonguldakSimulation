using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalilPasaKonagi : MonoBehaviour
{
    public Transform player;
    public GameObject tabela;
    public GameObject halil;
    public bool mesafe = false;
    public GameObject yanardoner;
    public GameObject text;
    bool yazi = true;
    [SerializeField] private AudioClip popSesi;
    private AudioSource m_AudioSource;

    // Start is called before the first frame update
    void Start()
    {
       m_AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(tabela.transform.position, player.position) < 3 && yazi == true)
        {
            mesafe = true;
            text.SetActive(true);
           
        }

        else if (Vector3.Distance(tabela.transform.position, player.position) > 3 && yazi == true)
        {
            mesafe = false;
            text.SetActive(false);     
        }

        if (mesafe == true && Input.GetKey(KeyCode.E) && yazi == true)
        {
            halil.SetActive(true);
            m_AudioSource.clip = popSesi;
            m_AudioSource.Play();
            text.SetActive(false);
            yanardoner.SetActive(false);
            yazi = false;
            Time.timeScale = 0;
        }
        if (Input.GetKey(KeyCode.Return))
        {
            halil.SetActive(false);
            Time.timeScale = 1;
        }
    }

        
    }
   