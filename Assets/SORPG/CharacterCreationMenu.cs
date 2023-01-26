using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class CharacterCreationMenu : MonoBehaviour
{
    public GameObject character;
    public List<OutfitChanger> outfitChangers = new List<OutfitChanger>();
    
    public void RandomizeCharactoer()
    {
        foreach (OutfitChanger changer in outfitChangers)
        {
            changer.Randomize();
        }    
    }

    public void Submit()
    {
        PrefabUtility.SaveAsPrefabAsset(character, "Assets/SORPG/Player.prefab");
        SceneManager.LoadScene(1);
    }
}
