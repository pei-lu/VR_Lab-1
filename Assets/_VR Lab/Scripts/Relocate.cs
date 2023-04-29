using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relocate : MonoBehaviour
{
    private GameObject referencelocation;
  
    // Start is called before the first frame update
    void Start()
    {
        referencelocation = GameObject.Find("anchors/panelAnchor");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3 (referencelocation.transform.position.x, referencelocation.transform.position.y - 0.5f,referencelocation.transform.position.z);
        this.transform .rotation = referencelocation.transform.rotation;
    }
}
