using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animasi : MonoBehaviour
{
    [SerializeField] public float nilaiX;
    [SerializeField] public float nilaiZ;
    public bool status_ground;
    public bool serongKanan;
    public bool serongKiri;
    public bool Maju;
    public bool Kiri;
    public bool Kanan;
    public bool JalanserongKanan;
    public bool JalanserongKiri;
    public bool JalanMaju;
    public bool JalanKiri;
    public bool JalanKanan;
    public float kecepatan_pemain;


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
        kecepatan_pemain = player.GetComponent<Player_Movement>().kecepatan;
        status_ground = player.GetComponent<Player_Movement>().isGrounded;
        anim.SetFloat("x", nilaiX);
        anim.SetFloat("z", nilaiZ);
        anim.SetBool("isGrounded", status_ground);
        if (nilaiX > 0 && nilaiZ > 0 && kecepatan_pemain==7){
            serongKanan = true;
            serongKiri  = false;
            Kiri        = false;
            Kanan       = false;
            Maju        = false;
            JalanKanan  = false;
            JalanKiri   = false;
            JalanMaju   = false;
            JalanserongKanan = false;
            JalanserongKiri  = false; 
        }else if(nilaiX < 0 && nilaiZ > 0 && kecepatan_pemain==7){
            serongKiri  = true;
            serongKanan = false;
            Kiri        = false;
            Kanan       = false;
            Maju        = false;
            JalanKanan  = false;
            JalanKiri   = false;
            JalanMaju   = false;
            JalanserongKanan = false;
            JalanserongKiri  = false;
        }else if(nilaiX < 0 && nilaiZ == 0 && kecepatan_pemain==7){
            serongKanan = false;
            serongKiri  = false;
            Kiri        = true;
            Kanan       = false;
            Maju        = false;
            JalanKanan  = false;
            JalanKiri   = false;
            JalanMaju   = false;
            JalanserongKanan = false;
            JalanserongKiri  = false;
        }else if(nilaiX > 0 && nilaiZ == 0 && kecepatan_pemain==7){
            serongKanan = false;
            serongKiri  = false;
            Kiri        = false;
            Kanan       = true;
            Maju        = false;
            JalanKanan  = false;
            JalanKiri   = false;
            JalanMaju   = false;
            JalanserongKanan = false;
            JalanserongKiri  = false;
        }else if(nilaiX == 0 && nilaiZ > 0 && kecepatan_pemain==7){
            serongKanan = false;
            serongKiri  = false;
            Kiri        = false;
            Kanan       = false;
            Maju        = true;
            JalanKanan  = false;
            JalanKiri   = false;
            JalanMaju   = false;
            JalanserongKanan = false;
            JalanserongKiri  = false;
        }else if(nilaiX == 0 && nilaiZ > 0 && kecepatan_pemain==3){
            serongKanan = false;
            serongKiri  = false;
            Kiri        = false;
            Kanan       = false;
            Maju        = false;
            JalanKanan  = false;
            JalanKiri   = false;
            JalanMaju   = true;
            JalanserongKanan = false;
            JalanserongKiri  = false;
        }else if(nilaiX > 0 && nilaiZ == 0 && kecepatan_pemain==3){
            serongKanan = false;
            serongKiri  = false;
            Kiri        = false;
            Kanan       = false;
            Maju        = false;
            JalanKanan  = true;
            JalanKiri   = false;
            JalanMaju   = false;
            JalanserongKanan = false;
            JalanserongKiri  = false;
        }else if(nilaiX < 0 && nilaiZ == 0 && kecepatan_pemain==3){
            serongKanan = false;
            serongKiri  = false;
            Kiri        = false;
            Kanan       = false;
            Maju        = false;
            JalanKanan  = false;
            JalanKiri   = true;
            JalanMaju   = false;
            JalanserongKanan = false;
            JalanserongKiri  = false;
        }else if(nilaiX > 0 && nilaiZ > 0 && kecepatan_pemain==3){
            serongKanan = false;
            serongKiri  = false;
            Kiri        = false;
            Kanan       = false;
            Maju        = false;
            JalanKanan  = false;
            JalanKiri   = false;
            JalanMaju   = false;
            JalanserongKanan = true;
            JalanserongKiri  = false;
        }else if(nilaiX < 0 && nilaiZ > 0 && kecepatan_pemain==3){
            serongKanan = false;
            serongKiri  = false;
            Kiri        = false;
            Kanan       = false;
            Maju        = false;
            JalanKanan  = false;
            JalanKiri   = false;
            JalanMaju   = false;
            JalanserongKanan = false;
            JalanserongKiri  = true;
        }else{
            serongKanan = false;
            serongKiri  = false;
            Kiri        = false;
            Kanan       = false;
            Maju        = false;
            JalanKanan  = false;
            JalanKiri   = false;
            JalanMaju   = false;
            JalanserongKanan = false;
            JalanserongKiri  = false;
        }
        anim.SetBool("SerongKanan", serongKanan);
        anim.SetBool("SerongKiri", serongKiri);
        anim.SetBool("Kanan", Kanan);
        anim.SetBool("Kiri", Kiri);
        anim.SetBool("Maju", Maju);
        anim.SetBool("Jalan_Serong_Kanan", JalanserongKanan);
        anim.SetBool("Jalan_Serong_Kiri", JalanserongKiri);
        anim.SetBool("Jalan_Kanan", JalanKanan);
        anim.SetBool("Jalan_Kiri", JalanKiri);
        anim.SetBool("Jalan", JalanMaju);
    }
}
