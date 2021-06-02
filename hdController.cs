using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hdController : MonoBehaviour
{
    Transform hotd_tr;
    Transform hdtxt_tr;
    public GameObject mytxt;
    // Start is called before the first frame update
    void Start()
    {
        hotd_tr = GetComponent<Transform>();
        hdtxt_tr = mytxt.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        Destroy(gameObject);
        Destroy(hdtxt_tr.gameObject);
    }
}
