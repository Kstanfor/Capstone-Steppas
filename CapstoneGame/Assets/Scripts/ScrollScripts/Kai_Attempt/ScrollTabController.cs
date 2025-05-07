using UnityEngine;

public class ScrollTabController : MonoBehaviour
{
    public GameObject scrollPage;  // the parent panel in the Canvas
    public GameObject scrollSlotPrefab;      // the ScrollSlot prefab

    void OnEnable()
    {
        RefreshTabs();
    }

    public void RefreshTabs()
    {
        // clear old
        foreach (Transform child in scrollPage.transform)
            Destroy(child.gameObject);

        // spawn one slot per collected scroll
        var collected = ScrollManager.Instance.GetCollected();
        for (int i = 0; i < collected.Count; i++)
        {
            var go = Instantiate(scrollSlotPrefab, scrollPage.transform);
            go.GetComponent<ScrollSlot>().Setup(collected[i]);
        }
    }
}
