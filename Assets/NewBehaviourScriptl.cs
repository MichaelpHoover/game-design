using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScriptl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      transform.localScale = this.transform.localScale + new Vector3(0.25f, 0.25f, 0.25f) * Time.deltaTime;
    }
}
