using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_system : MonoBehaviour
{
    public Text Score_text;

    static int score = 0;
    static int level = 1;

    IEnumerator Start()
    {
        while (true)
        {
            Score_text.text = "Score : " + score + " ";
            score += 10;

            if (score == 200)
                level++;

            yield return new WaitForSeconds(0.5f);
        }
    }

    public static int get_socre()
    {
        return score;
    }

    public static int get_level()
    {
        return level;
    }

    // Update is called once per frame
    void Update()
    {

    }
}