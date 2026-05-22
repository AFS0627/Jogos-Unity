using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giro : MonoBehaviour
{
    public int velocidade;
    private bool x;
    private bool y;
    private bool z;

    // Start is called before the first frame update
    void Start()
    {
        x = (Random.value > 0.6);
        y = (Random.value > 0.6);
        z = (Random.value > 0.6);

    }

    // Update is called once per frame
    void Update()
    {
        if(y)
            gameObject.transform.Rotate(Vector3.up * velocidade * Time.deltaTime, Space.World);

        if (x)
            gameObject.transform.Rotate(Vector3.right * velocidade * Time.deltaTime, Space.World);
        if (z)
            gameObject.transform.Rotate(Vector3.back * velocidade * Time.deltaTime, Space.World);
    }
}
