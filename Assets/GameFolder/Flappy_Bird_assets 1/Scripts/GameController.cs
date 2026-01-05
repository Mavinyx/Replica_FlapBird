using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public void ResetGame()
    {
        Time.timeScale = 1;
        //carrega a cena chamada "SampleScene", reiniciando o jogo
        SceneManager.LoadScene("SampleScene");
    }
}
