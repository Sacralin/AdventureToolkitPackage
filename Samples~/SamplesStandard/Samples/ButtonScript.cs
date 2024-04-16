using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{

    public GameObject hori1;
    public GameObject hori2;
    public GameObject hori3;
    
    public GameObject vert1;
    public GameObject vert2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            
            if (this.gameObject.name == "Button1")
            {
                hori1.SetActive(false);
                hori2.SetActive(false);
                hori3.SetActive(false);
            }

            if (this.gameObject.name == "Button2")
            {
                vert1.SetActive(false);
                vert2.SetActive(false);
                
            }


        }
    }

}
