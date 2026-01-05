using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundcontroller : MonoBehaviour
{
    //declara um variavel do tipo MeshRenderer
    MeshRenderer mr;

    void Start()
    {
        //associa a veriavel mr ao componente MeshRenderer do objeto
        mr = GetComponent<MeshRenderer>();
    }
    void Update()
    {
        //altera o offset da textura do material para criar um efeito de movimento, movendo a textura para a direita ao longo do tempo
        //o ponto serve pra acessar um nivel da hierarquia do componente
        mr.material.mainTextureOffset += Vector2.right * 0.5f * Time.deltaTime;
    }
}
