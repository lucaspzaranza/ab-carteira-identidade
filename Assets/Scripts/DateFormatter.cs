using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class DateFormatter : MonoBehaviour
{
    public TMP_InputField TMPRO_dateInputField;
    public InputField dateInputField;
    private string previousString;

    public void OnDateCharInput()
    {
        bool deletedSome = dateInputField.text.Length < previousString?.Length;
        string dateString = dateInputField.text;

        if (dateString.Length == 2 && !deletedSome)
        {
            dateInputField.text = dateString.Insert(2, "/");
            dateInputField.MoveTextEnd(true);
        }
        else if (dateString.Length == 2 && deletedSome)
        {
            dateInputField.text = dateString.Substring(0, 1);
        }
        else if (dateString.Length == 5 && !deletedSome)
        {
            dateInputField.text = dateString.Insert(5, "/");
            dateInputField.MoveTextEnd(true);
        }
        else if (dateString.Length == 5 && deletedSome)
        {
            dateInputField.text = dateString.Substring(0, 4);
        }

        previousString = dateInputField.text;
    }

    public void OnDateCharInputTMPro()
    {
        bool deletedSome = TMPRO_dateInputField.text.Length < previousString?.Length;
        string dateString = TMPRO_dateInputField.text;

        if (dateString.Length == 2 && !deletedSome)
        {
            TMPRO_dateInputField.text = dateString.Insert(2, "/");
            TMPRO_dateInputField.MoveToEndOfLine(false, false);
        }
        else if (dateString.Length == 2 && deletedSome)
        {
            TMPRO_dateInputField.text = dateString.Substring(0, 1);
        }
        else if (dateString.Length == 5 && !deletedSome)
        {
            TMPRO_dateInputField.text = dateString.Insert(5, "/");
            TMPRO_dateInputField.MoveToEndOfLine(false, false);
        }
        else if (dateString.Length == 5 && deletedSome)
        {
            TMPRO_dateInputField.text = dateString.Substring(0, 4);
        }

        previousString = TMPRO_dateInputField.text;
    }
}
