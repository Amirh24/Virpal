using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class TutorialScript : MonoBehaviour {

    private RawImage mTutorialRawImage;
    private Button mTutorialButton;
    private Toggle mTutorialToggle;

    public int testingVersion = 2; // Because player prefs is kept in memory, we will change thsi number as long as we test


    void Start () {
        print("Testing version number is " + testingVersion + " and version in memory is " + PlayerPrefs.GetInt("DontShowTutorial"));

        mTutorialRawImage = GetComponentInChildren<RawImage>();
        mTutorialButton = GetComponentInChildren<Button>();
        mTutorialToggle = GetComponentInChildren<Toggle>();

        if ((PlayerPrefs.GetInt("DontShowTutorial") == testingVersion)) {
            mTutorialRawImage.gameObject.SetActive(false);
            mTutorialButton.gameObject.SetActive(false);
            mTutorialToggle.gameObject.SetActive(false);
        }
    }

    public void RemoveTutorial()
    {
        mTutorialRawImage.gameObject.SetActive(false);
        mTutorialButton.gameObject.SetActive(false);
        mTutorialToggle.gameObject.SetActive(false);
    }

    public void DontShowTutorialAgain()
    {
        if ((PlayerPrefs.GetInt("DontShowTutorial") != testingVersion))
            {
            PlayerPrefs.SetInt("DontShowTutorial", testingVersion);
            }
    }
}
