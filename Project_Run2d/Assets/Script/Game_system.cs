using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_system : MonoBehaviour
{
    public Text Score_text;
    public Text End_Score_text;

    static int score = 0;
    static int high_score = 0;
    static int level = 1;

    static int game_play = 1;
    

    IEnumerator Start()
    {
        high_score = PlayerPrefs.GetInt("high_score", 0);

        Score_text.text = "Score : " + score + " ";

        while (game_play == 1)
        {
            score += 10;
            Score_text.text = "Score : " + score + " ";

            yield return new WaitForSeconds(0.5f);
        }
    }
    
    public static void reset()
    {
        score = 0;
        game_play = 1;
    }

    public static int get_socre()
    {
        return score;
    }

    public static int get_level()
    {
        return level;
    }

    public static int get_play()
    {
        return game_play;
    }

    public static void level_up()
    {
        level++;
    }

    public void game_end()
    {
        game_play = 0;

        if (high_score < score)
        {
            high_score = score;
            PlayerPrefs.SetInt("high_score", high_score);
        }

        End_Score_text.text = "Score : " + score + "\nHigh Score : " + high_score;

        FindObjectOfType<Score_board>().move();
    }

    

    // Update is called once per frame
    void Update()
    {

    }
}