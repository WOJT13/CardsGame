using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HUDButtonsController : MonoBehaviour
{
    public void onEndGameButtonClick() 
    {
        SceneManager.LoadScene(2);
    }
}
