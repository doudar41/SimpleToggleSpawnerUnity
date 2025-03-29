using UnityEngine;
using UnityEngine.UI;

public class IndexOfToggleToImage : MonoBehaviour
{
    Image image;
    [SerializeField]
    SpritesStorage collection;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        image = GetComponent<Image>();
    }

    public void IndexToImage(int index)
    {
        image.sprite = collection.spritesStored[index].backSprite;
    }
}
