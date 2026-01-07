using System.Threading;
using TMPro;
using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    Sprite sprite;
    Sprite highlightSprite;

    public TMP_Text buttonText;

    public GameObject player;
    
    public void Yadadadada()
    {
        print("Press");
    }

    public void LoadButton()
    {
        SceneManager.LoadScene("DummyScene");
    }

    public void LoadMenuButton()
    {
        SceneManager.LoadScene("Menu");
        AudioManager.instance.LoadVolume();
    }
 
    public void ButtonQuit()
    {
        Application.Quit();
    }

}
