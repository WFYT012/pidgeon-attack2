using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Make sure to include this for working with UI components like Image.

public class TabController : MonoBehaviour
{
    public Image[] tabImages;
    public GameObject[] pages;

    // Start is called before the first frame update
    void Start()
    {
        if (tabImages.Length > 0 && pages.Length > 0)
        {
            ActivateTab(0); // Start by activating the first tab.
        }
        else
        {
            Debug.LogError("TabController: tabImages or pages are not assigned or are empty.");
        }
    }

    public void ActivateTab(int tabNo)
    {
        if (tabNo < 0 || tabNo >= pages.Length || tabNo >= tabImages.Length)
        {
            Debug.LogError("TabController: Invalid tab number.");
            return;
        }

        // Deactivate all pages and set their corresponding tab images to grey
        for (int i = 0; i < pages.Length; i++)
        {
            pages[i].SetActive(false);
            tabImages[i].color = Color.grey;
        }

        // Activate the selected page and set its corresponding tab image to white
        pages[tabNo].SetActive(true);
        tabImages[tabNo].color = Color.white;
    }
}