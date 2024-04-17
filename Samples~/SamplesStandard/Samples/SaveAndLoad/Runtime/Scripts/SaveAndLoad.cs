using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveAndLoad : MonoBehaviour
{
    private FlagNodeTools flagNodeTools;
    private string flagsFilePath;
    private string dialogueFilePath;

    public GameObject activatorNpc;
    public GameObject activatorButton1;
    public GameObject activatorButton2;


    private void Start()
    {
        flagNodeTools = new FlagNodeTools();
        flagsFilePath = Application.persistentDataPath + "/flags.xml";
        dialogueFilePath = Application.persistentDataPath + "/dialogues.xml";
    }

    public void LoadAll()
    {
        LoadFlags();
        LoadDialogueState();
    }

    public void SaveAll()
    {
        SaveFlags();
        SaveDialogueState();
    }


    private void SaveFlags()  //saves the flags to file
    {
        List<FlagSO> listOfFlagAssets = flagNodeTools.GetAllFlagAssets();
        
        XmlSerializer serializer = new XmlSerializer(typeof(List<FlagSO>));

        using (FileStream stream = new FileStream(flagsFilePath, FileMode.Create))
        {
            serializer.Serialize(stream, listOfFlagAssets);
            Debug.Log($"File created at {flagsFilePath}");
        }
    }

    private void LoadFlags() //loads the flags from file
    {
        List<FlagSO> listOfFlagAssets;
        if (File.Exists(flagsFilePath))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<FlagSO>));
            using (FileStream stream = new FileStream(flagsFilePath, FileMode.Open))
            {
                listOfFlagAssets = serializer.Deserialize(stream) as List<FlagSO>;
                LoadFlagData(listOfFlagAssets);
            }
        }
        else
        {
            Debug.Log("File Not Found");     
        }

        

    }





    private void LoadFlagData(List<FlagSO> loadedFlags) // loads the filedata to the ingame objects
    {

        foreach (FlagSO loadedFlag in loadedFlags)
        {
            List<FlagSO> listOfFlagAssets = flagNodeTools.GetAllFlagAssets();

            foreach (FlagSO flagAsset in listOfFlagAssets)
            {
                if (flagAsset.name == loadedFlag.name)
                {
                    flagAsset.flagDatas.Clear();
                    flagAsset.flagDatas = loadedFlag.flagDatas;
                    
                }
            }

        }
    }


    
    private void SaveDialogueState() // saves dialogue state to file
    {
        List<DialogueSO> listOfDialogueAssets = GetAllDialogueAssets();
        XmlSerializer serializer = new XmlSerializer(typeof(List<DialogueSO>));
        using (FileStream stream = new FileStream(dialogueFilePath, FileMode.Create))
        {
            serializer.Serialize(stream, listOfDialogueAssets);
            Debug.Log($"File created at {dialogueFilePath}");
        }

    }

    private void LoadDialogueState() // loads dialogue state from file
    {
        List<DialogueSO> listOfDialogueAssets;

        if (File.Exists(dialogueFilePath))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<DialogueSO>));

            using (FileStream stream = new FileStream(dialogueFilePath, FileMode.Open))
            {
                listOfDialogueAssets = serializer.Deserialize(stream) as List<DialogueSO>;
                
                foreach (DialogueSO dialogueSO in listOfDialogueAssets)
                {
                    if (dialogueSO.name == "Main NPC Dialogue")
                    {
                        activatorNpc.GetComponent<DialogueTrigger>().dialogueSO = dialogueSO;
                    }
                    if (dialogueSO.name == "Button1")
                    {
                        activatorButton1.GetComponent<DialogueTrigger>().dialogueSO = dialogueSO;
                    }
                    if (dialogueSO.name == "Button2")
                    {
                        activatorButton2.GetComponent<DialogueTrigger>().dialogueSO = dialogueSO;
                    }
                }
            }
        }
        else
        {
            Debug.Log("File Not Found");
        }

        

    }

    private List<DialogueSO> GetAllDialogueAssets() // reusable tool
    {
        List<DialogueSO> listOfDialogueAssets = new List<DialogueSO>();

        string[] assetList = AssetDatabase.FindAssets("t:DialogueSO");
        if (assetList.Length != 0)
        {
            foreach (string asset in assetList)
            {
                string SOpath = AssetDatabase.GUIDToAssetPath(asset); // convert GUID into asset path
                DialogueSO dialogueSO = AssetDatabase.LoadAssetAtPath<DialogueSO>(SOpath); // load asset from path
                listOfDialogueAssets.Add(dialogueSO);
            }
        }
        return listOfDialogueAssets;
    }


}
