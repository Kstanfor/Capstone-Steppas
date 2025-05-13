using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScrollUIManager : MonoBehaviour
{
    public static ScrollUIManager Instance { get; private set; }

    [Header("Read Canvas")]
    public GameObject readPanel;          // ScrollReadPanel
    public TMP_Text titleText;            // TitleText
    public TMP_Text contentText;          // ContentText
    public Button closeButton;            // CloseButton

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    void Start()
    {
        readPanel.SetActive(false);
        closeButton.onClick.AddListener(CloseScroll);
    }

    public void OpenScroll(Scroll scroll)
    {
        // fill UI
        titleText.text = scroll.scrollTitle;
        contentText.text = scroll.scrollContent;

        // show
        readPanel.SetActive(true);

        // record collection
        ScrollManager.Instance.AddScroll(scroll);

        

    }

    public void CloseScroll()
    {
        readPanel.SetActive(false);
    }
}
