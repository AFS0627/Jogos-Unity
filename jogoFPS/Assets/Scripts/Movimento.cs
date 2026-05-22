using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    public int velocidade;
    private bool x;
    private bool y;
    private bool z;

    // Start is called before the first frame update
    void Start()
    {
        x = (Random.value > 0.7);
        y = (Random.value > 0.7);
        z = (Random.value > 0.7);
    }

    // Update is called once per frame
    void Update()
    {
        if (x)
        {
            gameObject.transform.Translate(Vector3.right * velocidade *
            Mathf.Cos(Time.timeSinceLevelLoad) * Time.deltaTime, Space.World);
        }
        if (y)
        {
            gameObject.transform.Translate(Vector3.up * velocidade *
            Mathf.Cos(Time.timeSinceLevelLoad) * Time.deltaTime, Space.World);
        }
        if (z)
        {
            gameObject.transform.Translate(Vector3.back * velocidade *
            Mathf.Cos(Time.timeSinceLevelLoad) * Time.deltaTime, Space.World);
        }
        
    }
}
