using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OyuncuKontrol : MonoBehaviour
{


    public float can = 100;
    public GameObject koronaekrani, bitisEkrani, porsuk;
    public Image canbar;
    public Transform solEl;
    public Transform sagEl;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void CoranaYaklasti()
    {     
            can -= 25 * Time.deltaTime;
            canbar.fillAmount = can / 100f;
            if (can <= 0)
            {
                Debug.Log("ÖLDÜ");
                koronaekrani.SetActive(true);

            }
           // return;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            Time.timeScale = 0;
            bitisEkrani.SetActive(true);
 
        }

        if (other.CompareTag("MadenGirisi"))
        {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
     
    }

}
