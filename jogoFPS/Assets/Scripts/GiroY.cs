using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiroY : MonoBehaviour
{
    public float velocidade = 90f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    gameObject.transform.Rotate(Vector3.up * velocidade
        * Time.deltaTime, Space.World);
    }
}
