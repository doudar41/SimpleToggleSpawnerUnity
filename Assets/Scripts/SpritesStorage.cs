using UnityEngine;
using System.Collections.Generic;



[CreateAssetMenu(fileName = "SpriteCollection", menuName = "ScriptableObjects/SpritesCollection", order = 1)]

[System.Serializable]
public class SpritesStorage : ScriptableObject
{
    public List<SpriteCouple> spritesStored = new List<SpriteCouple>();

}

[System.Serializable]

public class SpriteCouple
{
    public Sprite backSprite;
    public Sprite checkedSprite;
}