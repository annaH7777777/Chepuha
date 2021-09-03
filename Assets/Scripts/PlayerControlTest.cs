using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using System;
using Photon.Pun.Demo.SlotRacer.Utils;
using Photon.Pun.UtilityScripts;

public class PlayerControlTest : MonoBehaviour
{
    [SerializeField] List<GameObject> buttons;
    // Start is called before the first frame update
    /*IEnumerator Start()
    {
        yield return new WaitUntil(() => this.photonView.Owner.GetPlayerNumber() >= 0);

        //now we can set it up.
        this.SetButton(this.photonView.Owner.GetPlayerNumber());
    }*/

    private void SetButton(int index)
    {
        Instantiate(buttons[index]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
