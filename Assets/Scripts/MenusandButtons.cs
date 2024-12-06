using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenusScript : MonoBehaviour
{
  //Code that uses SceneManger.LoadScene for loading all the scenes
  //Including Menus and Levels through pressing Buttons.
    public void PlayGameLevel1()
    {
        SceneManager.LoadScene("BounceProjectileOwen_Level1");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("TitleScreen");
    }

    public void SettingsMenu()
    {
        SceneManager.LoadScene("ControlsScreen");
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }
 
    public void GoToLevel2()
    {
        SceneManager.LoadScene("BounceProjectileOwen_Level2");
    }

    public void GoToLevel3()
    {
        SceneManager.LoadScene("BounceProjectileOwen_Level3");
    }  
    
    //Method for quitting the game while in a build using Application.Quit.
    public void QuitGame()
    {
        Application.Quit();
    }



}
