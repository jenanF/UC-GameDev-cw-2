using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class day2 : MonoBehaviour
{
    public int score = 0;
    public int dbl = 1;
    public Text scoreText;
    public Text doubleText;
    public Text warningText;
    public Text popUp;

    // Start is called before the first frame update
    void Start()
    {
   
    }
    // Update is called once per frame
    void Update()
    {
        
    }
   public void addScore()
    {
       score++;
        scoreText.text = score.ToString();

        if (score == 20)
        {
            popUp.text = "Amazing!";
        }
        else
        {
            popUp.text = "";
        }

    }
    public void doub()
    {
        if ( score >= 15)
        {
            score -= 15;
            dbl++;
            scoreText.text = score.ToString();
            doubleText.text = dbl.ToString();
        }
        else
        {
            int v = 15 - score;
            warningText.text = "you need " + v + "more";
        }

    }
}
