using UnityEngine;
using System.Collections;
using System.Runtime.Serialization;
using System;

public enum PetGender
{
    Male = 0,
    Female = 1
}

public enum PetType
{
    Cat,
    Dog
}

[Serializable]
public class PetModel {


    public string name;
    public uint level;
    public uint hungriness;
    public uint happiness;
    public PetGender gender;
    public PetType type;
    public GameObject gameObj;
    public static string parent = "ImageTarget";

    public PetModel(string name, uint level, PetGender gender, PetType type)
    {
        this.name = name;
        this.level = level;
        this.gender = gender;
        this.type = type;
    }

    public void Init()
    {
        //Create a game object based on pet type
        gameObj = MonoBehaviour.Instantiate(Resources.Load(MapTypeToResource(type), typeof(GameObject))) as GameObject;

        //Add game object into UserDefinedTarget as a child
        Transform newParent = GameObject.FindWithTag(parent).GetComponent<Transform>();
        gameObj.transform.SetParent(newParent, false);
        gameObj.transform.rotation = new Quaternion(0,-180,0,0);
        gameObj.transform.localScale = new Vector3(2.3F, 2.3F, 2.3F);
    }
    public static string MapTypeToResource(PetType type)
    {
        switch (type)
        {
            case PetType.Cat:
                return "KittenNPC";
            case PetType.Dog:
                break;
            default:
                return null;
        }

        return null;
    }

    void SaveObjectToStorage()
    {
        string objStr = JsonUtility.ToJson(this);
        PlayerPrefs.SetString("PlayerObject", objStr);
        
    }

    public static PetModel LoadPlayerFromStorage()
    {
        string objStr = PlayerPrefs.GetString("PlayerObject");
        if (String.IsNullOrEmpty(objStr)) return null;
        return JsonUtility.FromJson<PetModel>(objStr);
    }
}
