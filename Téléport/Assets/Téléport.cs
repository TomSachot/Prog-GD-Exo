using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Téléport : MonoBehaviour
{
    public GameObject Receptacle;

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
        if (other.tag == "Téléport")
        {
            transform.position = Receptacle.transform.position;
        }
    }
}
