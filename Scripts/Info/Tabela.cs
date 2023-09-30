using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tabela : MonoBehaviour
{
    public Transform player;
    public GameObject tabela;
    public GameObject porsuk;
    public bool mesafe = false;
    public GameObject yanardoner;
    public GameObject text;
    bool yazi = true;
    [SerializeField] private AudioClip popSesi;
    private AudioSource m_AudioSource; 

    private void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Vector3.Distance(tabela.transform.position, player.position) < 3 && yazi == true)
        {
            mesafe = true;
            text.SetActive(true);
            Debug.Log("porsuga yaklastý");
        }

        else if (Vector3.Distance(tabela.transform.position, player.position) > 3 && yazi == true)
        {
            mesafe = false;
            text.SetActive(false);
            Debug.Log("porsuga uzaklasti");
        }

        if (mesafe == true && Input.GetKey(KeyCode.E) && yazi == true)
        {
            porsuk.SetActive(true);
            m_AudioSource.clip = popSesi;
            m_AudioSource.Play();
            text.SetActive(false);
            yanardoner.SetActive(false);
            yazi = false;
            Time.timeScale = 0;        
        }

        if (Input.GetKey(KeyCode.Return))
        {
            porsuk.SetActive(false);
            Time.timeScale = 1;
        }
    }     
}

 