using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScrollSlot : MonoBehaviour
{
    public Button button;
    public TMP_Text titleText;

    private Scroll scrollData;

    public void Setup(Scroll scroll)
    {
        scrollData = scroll;
        titleText.text = scroll.scrollTitle;
        button.onClick.AddListener(() => ScrollUIManager.Instance.OpenScroll(scrollData));
    }
}
