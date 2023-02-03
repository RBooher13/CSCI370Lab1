using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}
    public GameObject mine;
    public GameObject rocket;
    public TextMeshProUGUI scoreText;
    private int score;
    private int miss;
    public bool play;


    // Start is called before the first frame update
    void Start()
    {
        play = true;
        if (Instance == null){
            Instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (miss > 10) {
            mine.GetComponent<Mine>().StopThrow();
            play = false;
            rocket.GetComponent<Rocket>().launch();
        }
    }

    public void IncScore(int pts){
        score += pts;
        scoreText.text = "Points: " + score;
    }

    public void missed(){
        miss += 1;

    }
}
