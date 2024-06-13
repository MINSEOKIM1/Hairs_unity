using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PageManager : MonoBehaviour
{
    [SerializeField] private GameObject[] pages;

    [SerializeField] private String id;
    [SerializeField] private String pw;

    [SerializeField] private TMP_InputField idInput;
    [SerializeField] private TMP_InputField pwInput;

    private void Start()
    {
        pages[0].SetActive(true);
        for (int i = 1; i < pages.Length; i++)
        {
            pages[i].SetActive(false);
        }
    }
    
    
        private int _currentPageNum;

    public void MovePage(int pageNum)
    {
        pages[_currentPageNum].SetActive(false);
        pages[pageNum].SetActive(true);
        _currentPageNum = pageNum;
    }

    public void Login(int pageNum)
    {
        if (idInput.text.Equals(id) && pwInput.text.Equals(pw))
        {
            MovePage(pageNum);
        }
    }
}
