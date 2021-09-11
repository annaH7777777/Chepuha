using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] Text text;
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTextEnter()
    {
        int buttonNum = int.Parse(gameObject.tag) - 1;
        if (text.text != "" || text.text != " ")
            SendText(buttonNum);
        text.GetComponentInParent<InputField>().gameObject.SetActive(false);
        gameObject.SetActive(false);
    }

    [PunRPC]
    private void SendText(int buttonNum)
    {
        gameManager.OnTextEnter(text.text, buttonNum);
    }


}
