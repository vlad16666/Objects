using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hmController : MonoBehaviour
{
    Transform hm_tr;
    Transform hmtxt_tr;
    public GameObject hmtxt;
    // Start is called before the first frame update
    void Start()
    {
        hm_tr = GetComponent<Transform>();
        hmtxt_tr = hmtxt.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        Destroy(hm_tr.gameObject);
        Destroy(hmtxt_tr.gameObject);
    }
}
