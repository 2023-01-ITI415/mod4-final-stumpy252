using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Collectible : MonoBehaviour{
    public TextMeshProUGUI countText;
    public GameObject firstCollectible;
    private int count;
    void Start(){
        firstCollectible.SetActive(false);
        count = 0;
        SetCountText();
    }
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Player")){
            count += 1;
            SetCountText();
            this.gameObject.SetActive(false); 
        }
       
    }
    
    void SetCountText()
    {
        countText.text = "Collectibles: " + count.ToString();
        if(count == 1){
            firstCollectible.SetActive(true);
            Invoke("SetFalse", 5.0f);
        }
        
    }
    void SetFalse(){
            firstCollectible.SetActive(false);
        }
   
} 
