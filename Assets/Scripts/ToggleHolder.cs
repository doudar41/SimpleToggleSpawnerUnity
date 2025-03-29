using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


[RequireComponent(typeof(Toggle))]
public class ToggleHolder : MonoBehaviour
{
    Toggle toggle;
    public int index = 0;
    [SerializeField]
    Image back, check;

    public UnityEvent<int> sendIndex;

    private void Start()
    {
        toggle = GetComponent<Toggle>();
        toggle.onValueChanged.AddListener(Click);
    }

    public void SetListener(GetToggleIndex toggleSpawner)
    {
        sendIndex.AddListener(toggleSpawner.GetToggle);
    }

    void Click(bool check)
    {
        if (check)
        {
            sendIndex.Invoke(index);
        }
        toggle.isOn = false;

    }

    public void SetImages(Sprite imgBack, Sprite checkImg)
    {
        back.sprite = imgBack;
        check.sprite = checkImg;
    }
}
