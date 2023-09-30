using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI; 

public class MadenciHareket : MonoBehaviour
{
    bool oyunDevam = true;
    Animator anim;
    private GameObject oyuncu;
    NavMeshAgent nMesh;
    public bool mesafe = false;
    public bool hedefeGit = true;
    public Image canImaji;
    private float canSayisi = 100f;



    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        oyuncu = GameObject.Find("FPSController");
        nMesh = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {

        
        if (hedefeGit)
            nMesh.destination = oyuncu.transform.position;
        else
            nMesh.velocity = Vector3.zero;

        if (Vector3.Distance(transform.position, oyuncu.transform.position) < 5)
        {
            mesafe = true;
            Debug.Log("madenci yaklaþtý");
        }

        else
        {
            mesafe = false;
            Debug.Log("uzaklaþtý");
        }

        if (GameObject.FindGameObjectWithTag("mask").GetComponent<MeshRenderer>().enabled == false)
        {
            if (mesafe == true)
            {
                oyuncu.GetComponent<OyuncuKontrol>().CoranaYaklasti();
            }
        }

    }


    private void OnTriggerEnter(Collider hasta)
    {
        if (hasta.CompareTag("asi"))
        {
            hedefeGit = false;
            Debug.Log("çarpiþma oldu");
            Destroy(hasta.gameObject);
            anim.SetTrigger("durma");
            anim.SetBool("yurume", false);
            GameObject.FindGameObjectWithTag("mask").GetComponent<MeshRenderer>().enabled = true;
            Destroy(gameObject, 2f);
        }
    }

    
    
}
