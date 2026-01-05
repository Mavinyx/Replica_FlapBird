using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    public TextMeshProUGUI scoreView;
    public Transform GameOver;

    // o serializefield permite que a variavel seja editavel no inspetor do unity mesmo sendo privada
    [SerializeField] float jump;
    [SerializeField] int score;

    void Start()
    {   
        //associa a variavel rb ao componente Rigidbody2D do objeto
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        // input -> sugere entrada de dados do usuario
        // getkeydown -> metodo que verifica se uma tecla foi pressionada
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = Vector2.up * jump;
        }
    }

    //função pré definida que é chamada quando o objeto trigger colide com outro objeto que possui um collider2D
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //verifica se o objeto colidido possui a tag "AddScore"
        if (collision.CompareTag("AddScore"))
        {
            score++;
            scoreView.text = score.ToString();
        }
        if(collision.CompareTag("Pipe"))
        {
            this.enabled = false;
            score = 0;
            //faz o objeto GameOver ativo na cena
            GameOver.gameObject.SetActive(true);
            Invoke("Pause",2);
        }
    }
    void Pause()
    {
        Time.timeScale = 0;
    }
}
