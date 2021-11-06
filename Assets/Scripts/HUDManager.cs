using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    public Image currentEnergy;
    private GameObject player;
    private float energy = 200;
    private float maxEnergy = 200;
    private float kecepatan;
    private float kecepatanLari;
    private float Input_X;
    private float Input_Z;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        kecepatanLari = player.GetComponent<Player_Movement>().speed_lari;
    }

    // Update is called once per frame
    void Update()
    {
        kecepatan = player.GetComponent<Player_Movement>().kecepatan;
        Input_X = player.GetComponent<Player_Movement>().x;
        Input_Z = player.GetComponent<Player_Movement>().z;
        UpdateEnergy();
        EnergyDrain();
    }

    private void EnergyDrain()
    {
        if(kecepatan == kecepatanLari)
        {
            if(Input_X>0 | Input_Z>0)
            {
                if(energy>0){
                    energy -= 10 * Time.deltaTime;
                }
            }
        }
        else
        {
            if(energy < maxEnergy)
            {
                energy += 15 * Time.deltaTime;   
            }
        }
    }

    private void UpdateEnergy()
    {
        float ratio = energy / maxEnergy;
        currentEnergy.rectTransform.localScale = new Vector3(ratio, 1, 1);
    }
}
