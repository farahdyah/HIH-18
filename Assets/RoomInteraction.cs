using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomInteraction : MonoBehaviour
{
    public GameObject CloseRoom; //Object yang akan di close atau Inactive 
    public GameObject LoadingPanel; //Object yang akan nutupin perpindahan object antara close room dan open room
    public GameObject OpenRoom; //Object yang akan di open atau Active 
    public Transform SpawnPosition;
    public PlayerMovement Player;

    public void Awake()
    {
        Player = FindObjectOfType<PlayerMovement>();
    }      

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SwitchRoom();

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // CloseRoom.SetActive(!CloseRoom.activeSelf);
            // OpenRoom.SetActive(!OpenRoom.activeSelf);
        }
    }

    //Switch room dipanggil ketika player berinteraksi dengan pintu" yang bisa di Interaksi
    public void SwitchRoom()
    {
        
        StartCoroutine(SwitchingRoom());
    }

    IEnumerator SwitchingRoom()
    {
        LoadingPanel.SetActive(true); // Hanya bertugas untuk menutupi proses perpindahan dari Close room ke Open room 
        yield return new WaitForSeconds(0.5f); // Timer bebas  minimal 0.5f || 1f
        Player.transform.position = SpawnPosition.position;
        CloseRoom.SetActive(!CloseRoom.activeSelf); //Close room
        OpenRoom.SetActive(!OpenRoom.activeSelf); //Open room
        yield return new WaitForSeconds(0.5f);
        LoadingPanel.SetActive(false); // Tutup si loading biar keliatan Room yang sudah di open 
        
    }
}
