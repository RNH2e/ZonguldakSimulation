using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CovidKopyalama : MonoBehaviour
{
    public GameObject covid;
    private float zaman_Sayaci;
    private float olusum_Sureci = 15;
    // Start is called before the first frame update
    void Start()
    {
        zaman_Sayaci = olusum_Sureci;
    }

    // Update is called once per frame
    void Update()
    {
        zaman_Sayaci -= Time.deltaTime;
        if (zaman_Sayaci<0)
        {
            Vector3 pos = new Vector3(Random.Range(166f,338f), 25.0f, Random.Range(197f,334f));
            Instantiate(covid, pos, Quaternion.identity);
            zaman_Sayaci = olusum_Sureci;
        }
    }
}
