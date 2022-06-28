using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
The below namespace is necessary to dynamically load scenes
*/
using UnityEngine.SceneManagement;
/**
The below namespaces are necesary for UI elements management
**/
using UnityEngine.UI;
using TMPro;

public class LoadGame : MonoBehaviour
{
    public void LoadGameScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
}
