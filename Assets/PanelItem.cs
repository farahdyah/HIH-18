using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelItem : MonoBehaviour
{
    [SerializeField] GameObject panelNextScene;
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Player"))
        {
            panelNextScene.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if (other.CompareTag("Player"))
        {
            panelNextScene.SetActive(false);
        }
    }
}
