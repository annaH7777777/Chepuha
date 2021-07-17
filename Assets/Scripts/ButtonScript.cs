using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        gameManager.OnTextEnter(text);
        text.GetComponentInParent<InputField>().gameObject.SetActive(false);
        gameObject.SetActive(false);
    }
}
