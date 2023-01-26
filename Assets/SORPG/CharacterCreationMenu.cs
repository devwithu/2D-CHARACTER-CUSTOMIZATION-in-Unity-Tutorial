using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CharacterCreationMenu : MonoBehaviour
{
    [FormerlySerializedAs("OutfitChangers")] public List<OutfitChanger> outfitChangers = new List<OutfitChanger>();
    
    public void RandomizeCharactoer()
    {
        foreach (OutfitChanger changer in outfitChangers)
        {
            changer.Randomize();
        }    
    }
}
