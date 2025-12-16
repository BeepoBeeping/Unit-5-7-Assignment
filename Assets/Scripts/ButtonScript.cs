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

    public void LoadButton()
    {
        SceneManager.LoadScene("DummyScene");
        FindFirstObjectByType<AudioManager>().PlayClip("ButtonClick");
    }

    public void LoadMenuButton()
    {
        SceneManager.LoadScene("Menu");
        FindFirstObjectByType<AudioManager>().PlayClip("ButtonClick");
    }

    public void ButtonClick()
    {
        FindFirstObjectByType<AudioManager>().PlayClip("ButtonClick");
    }

    public void ButtonBack()
    {
        FindFirstObjectByType<AudioManager>().PlayClip("ButtonBack");
    }

    public void ButtonHover()
    {
        FindFirstObjectByType<AudioManager>().PlayClip("ButtonHover");
    }

    public void ButtonInactive()
    {
        FindFirstObjectByType<AudioManager>().PlayClip("ButtonInactive");
    }

    public void ButtonQuit()
    {
        Application.Quit();
    }

    public void OnMouseEnter()
    {
        ButtonHover();
    }

}
