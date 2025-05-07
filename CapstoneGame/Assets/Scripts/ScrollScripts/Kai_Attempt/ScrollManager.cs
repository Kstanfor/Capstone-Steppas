using System.Collections.Generic;
using UnityEngine;

public class ScrollManager : MonoBehaviour
{
    public static ScrollManager Instance { get; private set; }

    // runtime list of collected scrolls
    private List<Scroll> collected = new List<Scroll>();

    void Awake()
    {
        if (Instance == null) { Instance = this; DontDestroyOnLoad(gameObject); }
        else Destroy(gameObject);
    }

    public void AddScroll(Scroll scroll)
    {
        if (!collected.Contains(scroll))
            collected.Add(scroll);
    }

    public IReadOnlyList<Scroll> GetCollected() => collected;
}
