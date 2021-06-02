using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class flController : MonoBehaviour
{
    Transform fl_tr;
    Transform fltxt_tr;
    public GameObject fltxt;
    // Start is called before the first frame update
    void Start()
    {
        fl_tr = GetComponent<Transform>();
        fltxt_tr = fltxt.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        Destroy(fl_tr.gameObject);
        Destroy(fltxt_tr.gameObject);
        SceneManager.LoadScene("scene");
    }
}
