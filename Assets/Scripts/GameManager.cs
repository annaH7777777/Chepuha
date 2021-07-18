using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> inputFields;
    public List<String> texts = new List<String>();
    public Text finalText;
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < inputFields.Count; i++)
            texts.Add("");
    }
    
    public void OnTextEnter(Text text)
    {
        i = inputFields.IndexOf(text.gameObject);
        texts.RemoveAt(i);
        texts.Insert(i, inputFields[i].GetComponent<Text>().text);
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
