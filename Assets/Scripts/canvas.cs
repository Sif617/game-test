using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvas : MonoBehaviour
{
    public Image healthbar;
    public int healthamount=100;
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        healthbar.fillAmount = healthamount/100;
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void movetrue() 
    { 
        
        movement_player mplayer = FindObjectOfType<movement_player>();

        mplayer.charactermove();
    
    }  

    public void damagee()
    {
        damage = -healthamount / 100;
        healthbar.fillAmount = damage;

    }

    public void finishplayer()
    {
        if(damage == 0)
        {
            movement_player playerr = FindObjectOfType<movement_player>();

            playerr.characterfalse();
        }
    }

}
