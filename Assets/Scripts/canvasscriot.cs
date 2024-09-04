using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvasscriot : MonoBehaviour
{
    public Image healthbar;
    public float healthamount;
    public float damage;
    public float currenthealth;
    // Start is called before the first frame update
    void Start()
    {
        damage = 20;
       healthamount = currenthealth;
    }

    // Update is called once per frame
    void Update()
    {

       /* healthbar.fillAmount = Mathf.Clamp(currenthealth / healthamount, 0, 1);*/
    }


    public void movetrue()
    {

        movement_player mplayer = FindObjectOfType<movement_player>();

        mplayer.charactermove();

    }

    public void damagee()
    {
       currenthealth -= damage;
       healthbar.fillAmount = currenthealth/100;

    }

    public void finishplayer()
    {
        if (currenthealth == 0)
        {
            movement_player playerr = FindObjectOfType<movement_player>();

            playerr.characterfalse();
        }
    }
}
