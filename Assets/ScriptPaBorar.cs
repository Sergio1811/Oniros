using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPaBorar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, this.transform.position + Vector3.left, 5 * Time.deltaTime);
    }
}
