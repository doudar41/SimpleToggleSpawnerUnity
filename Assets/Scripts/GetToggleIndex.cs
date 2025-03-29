using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.Events;


[RequireComponent(typeof(ToggleGroup))]
public class GetToggleIndex : MonoBehaviour
{
    [SerializeField]
    GameObject togglePrefab;
    [SerializeField]
    Transform togglePanel;
    [SerializeField]
    SpritesStorage spriteCollection; // Sprite collection is a pairs of background and checked sprites

    Dictionary<int, Sprite[]> toggleImageSource = new Dictionary<int, Sprite[]>();
    ToggleGroup group;

    public UnityEvent<int> getToggleIndex;

    private void Start()
    {
        for (int i = 0; i < spriteCollection.spritesStored.Count; i++)
        {
            toggleImageSource.Add(i, new Sprite[2] { spriteCollection.spritesStored[i].backSprite, spriteCollection.spritesStored[i].checkedSprite });
        }
        SpawnToggles();
        group = GetComponent<ToggleGroup>();
    }

    public void SpawnToggles()
    {
        for (int i = 0; i < toggleImageSource.Count; i++)
        {
            var toggleChild = Instantiate(togglePrefab, togglePanel);
            ToggleHolder t = toggleChild.GetComponent<ToggleHolder>();
            t.index = i;
            t.SetListener(this);
            toggleChild.GetComponent<Toggle>().group = group;
            if (t == null) print("null reference");
            if (toggleImageSource.TryGetValue(i, out Sprite[] background)) 
            {
                t.SetImages(background[0], background[1]);
            } 
        }
    }

   public void GetToggle(int index)
    {
        getToggleIndex.Invoke(index);
    }



}
