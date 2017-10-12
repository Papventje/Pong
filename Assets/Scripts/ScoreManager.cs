using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    [SerializeField] private Text player1Text;
    [SerializeField] private Text player2Text;

    private float scorePlayer1 = 0;
    private float scorePlayer2 = 0;

    [SerializeField] private GameObject cube;
	
	void Update () {
        
        //set the score text
        player1Text.text = "" + scorePlayer1;
        player2Text.text = "" + scorePlayer2;

        //check if the ball is behind player 1
        if (cube.transform.position.x < Camera.main.transform.position.x - 9)
        {
            scorePlayer2 += 1;
            //Reset Game
            cube.transform.position = new Vector3(0, Random.Range(-1.6f, 1.6f), 0);
        }
        //check if the ball is behind player 2
        if(cube.transform.position.x > Camera.main.transform.position.x + 9)
        {
            scorePlayer1 += 1;
            //Reset Game
            cube.transform.position = new Vector3(0, Random.Range(-1.6f, 1.6f), 0);
        }
	}
}
