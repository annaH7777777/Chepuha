using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInstantiater : MonoBehaviour
{
    Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas = FindObjectOfType<Canvas>();
    }

    private void OnEnable()
    {
        PhotonServer.OnEpisodeActivation += InstantiateButton;
    }

    private void InstantiateButton(int prefabIndex)
    {
        Debug.Log("Instantiate a button");
        GameObject panel = Instantiate(Resources.Load<GameObject>("Panel" + prefabIndex), new Vector3(0, 0, 0), Quaternion.identity);
        panel.transform.SetParent(canvas.gameObject.transform);
        panel.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
    }
}
