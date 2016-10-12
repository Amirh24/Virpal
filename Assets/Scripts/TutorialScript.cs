using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class TutorialScript : MonoBehaviour {

    // private TutorialImage mQualityDialog;
    private RawImage mTutorialRawImage;
    private Button mTutorialButton;
    private Toggle mTutorialToggle;


    void Start () {
        mTutorialRawImage = GetComponentInChildren<RawImage>();
        mTutorialButton = GetComponentInChildren<Button>();
        mTutorialToggle = GetComponentInChildren<Toggle>();

    }

    public void RemoveTutorial()
    {
        mTutorialRawImage.gameObject.SetActive(false);
        mTutorialButton.gameObject.SetActive(false);
        mTutorialToggle.gameObject.SetActive(false);
    }
}
