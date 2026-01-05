using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PipeController: MonoBehaviour
{
    void Start()
    {
        // destroi o objeto apos 3 segundos, 2 parametros, o objeto a ser destruido e o tempo em segundos
        Destroy(gameObject,3);
    }
    void Update()
    {
        // acessa a propriedade position do transform do objeto e adiciona um vetor que move o objeto para a direita
        transform.position += Vector3.right * -2.5f * Time.deltaTime;
    }
}
