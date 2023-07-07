using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class PlayerInventory : MonoBehaviour
{
    public int NumberOfDiamonds { get; private set; }
    public float NumberOfLives = 3;


    public UnityEvent<PlayerInventory> OnDiamondCollected;
    public UnityEvent<PlayerInventory> OnLivesLosed;


    public void DiamondCollected()
    {
        NumberOfDiamonds++;
        OnDiamondCollected.Invoke(this);
    }


    public void LivesLosed()
    {
        NumberOfLives--;
        OnLivesLosed.Invoke(this);
        if (NumberOfLives == 0) {
            Invoke(nameof(ReloadLevel), 0f);
        }
        
    }
    
   

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }




}