using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Select : MonoBehaviour
{
    public static int select;
    public GameObject player1;
    public GameObject player2;
    public GameObject player1Select;
    public GameObject player2Select;
    public static InputField name;

    private void Awake()
    {
        name = GetComponent<InputField>();
    }
    public void Player1Select()
    {
        select = 1;
        player1.SetActive(false);
        player2.SetActive(false);
        player1Select.SetActive(true);
    }

    public void Player2Select()
    {
        select = 2;
        player1.SetActive(false);
        player2.SetActive(false);
        player2Select.SetActive(true);
    }

    public void ReSelect()
    {
        select = 0;
        player1.SetActive(true);
        player2.SetActive(true);
        player1Select.SetActive(false);
        player2Select.SetActive(false);
    }

    public void GameStart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
