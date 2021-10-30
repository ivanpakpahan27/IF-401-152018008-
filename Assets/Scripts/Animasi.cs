using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animasi : MonoBehaviour
{
    private float nilaiX;
    private float nilaiZ;
    private bool status_ground;


    private Animator anim;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        player = GameObject.Find("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        nilaiX = player.GetComponent<Player_Movement>().x;
        nilaiZ = player.GetComponent<Player_Movement>().z;
        status_ground = player.GetComponent<Player_Movement>().isGrounded;
        anim.SetFloat("x", nilaiX);
        anim.SetFloat("z", nilaiZ);
        anim.SetBool("isGrounded", status_ground);
    }
}
