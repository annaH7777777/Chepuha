using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //public List<GameObject> inputFields;
    public int playerCount = 2;
    public List<String> texts = new List<String>();
    public Text finalText;
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < playerCount; i++)
            texts.Add("");
    }
    
    public void OnTextEnter(String text, int buttonNum)
    {
        //i = inputFields.IndexOf(text.gameObject);
        texts.RemoveAt(buttonNum);
        texts.Insert(i, text);
        if (!texts.Contains(""))
        {
            SetFinishText();
        }
    }

    private void SetFinishText()
    {
        String finalTextString = "";
        foreach(String text in texts)
        {
            finalTextString += text;
            finalTextString += " ";
        }
        finalText.text = finalTextString;
    }
}
