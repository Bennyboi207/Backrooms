using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsBack : MonoBehaviour
{
    public void CreditGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -3);
    }

}
