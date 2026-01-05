using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PipeSpawner: MonoBehaviour
{
    public Transform pipe;
    void Start()
    {
        //função que chama o metodo Spawn repetidamente, 3 parametros, o nome do metodo, o tempo para a primeira chamada e o intervalo entre as chamadas
        InvokeRepeating("Spawn", 0, 2);
    }
    void Update()
    {
        
    }
    //metodo que instancia o cano
    void Spawn()
    {
        //instancia objeto na pocisao desejada
        //vector 3 permite definir a posiçao em x,y,z
        //transform.position.x pega a posiçao x do objeto que contem esse script
        // Função Random.Range(-3, 3) gera um numero aleatorio entre -3 e 3 para a posiçao y
        // Quaternion.identity define a rotaçao do objeto como padrao (sem rotaçao)
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(-3, 3), 0), Quaternion.identity);
    }
}
