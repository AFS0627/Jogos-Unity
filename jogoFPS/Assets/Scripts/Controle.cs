using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle : MonoBehaviour
{
    public float velocidade = 3.0f;
    public float gravidade = 200.0f;
    private CharacterController meuControle;

    // Start is called before the first frame update
    void Start()
    {
        meuControle = gameObject.GetComponent<CharacterController>();
    }      

    // Update is called once per frame
    void Update()
    {
    //Movimento em z
    Vector3 movimentoZ = Input.GetAxis("Vertical") *
        Vector3.forward * velocidade;

    //Movimento em X
    Vector3 movimentoX = Input.GetAxis("Horizontal") *
        Vector3.right * velocidade;

    Vector3 movimento = transform.TransformDirection
       (movimentoZ + movimentoX);

    //Movimento em y (gravidade)
    movimento.y -= gravidade * Time.deltaTime;

    meuControle.Move(movimento * Time.deltaTime);
    }
}
