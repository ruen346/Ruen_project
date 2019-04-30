using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class TextManager : MonoBehaviour
{
    public Text Name_Text;
    public Text Messge_Text;

    List<string> TextList;

    List<string> Name;
    List<string> Messge;

    private Queue<string> Name_q;
    private Queue<string> Messge_q;


    void Start()
    {
        // txt파일 인풋
        TextList = new List<string>();
        string path = Application.dataPath + "/script.txt";
        string[] textValue = System.IO.File.ReadAllLines(path);
        if (textValue.Length > 0)
        {
            for (int i = 0; i < textValue.Length; i++)
            {
                TextList.Add(textValue[i].ToString());
            }
        }

        Name = new List<string>();
        Messge = new List<string>();

        Name_q = new Queue<string>();
        Messge_q = new Queue<string>();

        foreach (string script in TextList)
        {
            string Name_cut = script.Substring(0,script.IndexOf(':'));
            string Messge_cut = script.Substring(script.IndexOf(':') + 1);

            Name.Add(Name_cut);
            Messge.Add(Messge_cut);
        }

        StartDialogue(); // 시작해버림
    }

    public void StartDialogue() // 처음 대화 시작
    {
        Name_q.Clear();
        Messge_q.Clear();

        foreach (string Name_eq in Name)
        {
            Name_q.Enqueue(Name_eq);
        }
        foreach (string Messge_eq in Messge)
        {
            Messge_q.Enqueue(Messge_eq);
        }


        DisplayNextSentence();
    }

    public void DisplayNextSentence() // 대화 진행
    {
        if (Name_q.Count == 0)
        {
            EndDialogue();
            return;
        }

        string Name_eq = Name_q.Dequeue();
        Name_Text.text = Name_eq;

        string Messge_wq = Messge_q.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(Messge_wq));
        }

    IEnumerator TypeSentence(string sentence) // 한글자씩 출력
    {
        Messge_Text.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            Messge_Text.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        Name_Text.text = "대화 종료";
        Messge_Text.text = "대화 종료";
    }
}
