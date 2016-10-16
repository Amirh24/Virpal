using UnityEngine;
using System.Collections;
using Virpal;


public class gameManager : MonoBehaviour {

    //W  private UserDefinedTarget
    // Use this for initialization
    //  mQualityImageUIText = GameObject.Find("QualityImageText").GetComponent<Text>();
    private GameObject m_UserDefinedTarget;

    void Start () {
        m_UserDefinedTarget = GameObject.Find("UserDefinedTarget");
    }

    // Update is called once per frame
    void Update () {
	    
	}


    /*
        void RenderPet(IPet pet)
        {
          switch ((PET_TYPES) pet.GetType())
            {
                case PET_TYPES.Cat:
                    break;

            }
        }
        */
}
