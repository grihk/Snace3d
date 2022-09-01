using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class LoadLevel : MonoBehaviour
{
    public float delay = 3;
    public UnityEvent OnEat;

    public string levelName;
    public IEnumerator Start()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("MainMenu");
        if (OnEat != null)
        {
            OnEat.Invoke();
        }
    }
     
            
                
}

