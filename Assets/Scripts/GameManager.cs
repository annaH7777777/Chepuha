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
        //Debug.Log(inputFields[0].GetComponent<Text>());
        //inputFields[0].onValueChanged.AddListener(delegate { ValueChangeCheck(); });
        texts.Add("");
        texts.Add("");
        texts.Add("");
        texts.Add("");
        texts.Add("");
    }

    private void ValueChangeCheck()
    {
        Debug.Log("Value Changed");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTextEnter(Text text)
    {
        i = inputFields.IndexOf(text.gameObject);
        Debug.Log("i is " + i);
        //Debug.Log(inputFields[i].GetComponent<Text>());
        Debug.Log(texts.Count);
        //Debug.Log("texts i " + texts[i]);
        //if (texts[i] == "0")
        texts.RemoveAt(i);
        texts.Insert(i, inputFields[i].GetComponent<Text>().text);
        //else
        //{
        //    //texts.RemoveAt(i);
        //    texts.Insert(i, inputFields[i].GetComponent<Text>().text);
        //}

        if (!texts.Contains(""))
        {
            SetFinishText();
        }
        //i++;
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
