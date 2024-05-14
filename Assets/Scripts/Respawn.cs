using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using UnityEngine.UI;

public class Respawn : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;

    void Start()
    {
            if (Select.select == 1)
            {
                player1.SetActive(true);
            }
            else if (Select.select == 2)
            {
                player2.SetActive(true);
            }
    }
}
