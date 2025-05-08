using UnityEngine;

public class ScrollTabController : MonoBehaviour
{
    public GameObject scrollPage;  // the parent panel in the Canvas
    public GameObject scrollSlotPrefab;      // the ScrollSlot prefab
    public int slotCount;
    public GameObject[] scrollPrefab;

    void Start()
    {
        for (int i = 0; i < slotCount; i++)
        {
            ScrollSlot slot = Instantiate(scrollSlotPrefab, scrollPage.transform).GetComponent<ScrollSlot>();

            if (i < scrollPrefab.Length)
            {
                GameObject scroll = Instantiate(scrollPrefab[i], slot.transform);
                scroll.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
                slot.currentItem = scroll;
            }

        }
    }

    public bool AddScroll(GameObject scrollPrefab)
    {
        foreach (Transform slotTransform in scrollPage.transform)
        {
            Slot slot = slotTransform.GetComponent<Slot>();
            if (slot != null && slot.currentItem == null)
            {
                GameObject newScroll = Instantiate(scrollPrefab, slot.transform);
                newScroll.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
                slot.currentItem = newScroll;
                return true;
            }
        }
        Debug.Log("Scroll's Full");
        return false;
    }

    // void OnEnable()
    // {
    //    RefreshTabs();
    // }

    // public void RefreshTabs()
    // {
    // clear old
    //   foreach (Transform child in scrollPage.transform)
    //       Destroy(child.gameObject);

    // spawn one slot per collected scroll
    //   var collected = ScrollManager.Instance.GetCollected();
    //  for (int i = 0; i < collected.Count; i++)
    // {
    //   var go = Instantiate(scrollSlotPrefab, scrollPage.transform);
    //    go.GetComponent<ScrollSlot>().Setup(collected[i]);
    // }
    // }
}
