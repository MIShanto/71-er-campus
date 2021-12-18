using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] GameObject mainInfoPanel;
    [SerializeField] GameObject historyPanel;
    [SerializeField] GameObject riddlePanel;
    [SerializeField] GameObject gotoRiddleButton;
    [SerializeField] GameObject gotoHistoryButton;
    [SerializeField] GameObject closePanelButton;


    private void OnMouseDown()
    {
        Debug.LogError(this.gameObject.tag);

        if (this.gameObject.CompareTag("Click Btn"))
        {
            mainInfoPanel.SetActive(true);
            historyPanel.SetActive(true);
            gotoRiddleButton.SetActive(true);

            riddlePanel.SetActive(false);
            gotoHistoryButton.SetActive(false);
            closePanelButton.SetActive(false);
        }
        if (this.gameObject.CompareTag("Goto Riddle Btn"))
        {
            historyPanel.SetActive(false);
            gotoRiddleButton.SetActive(false);

            gotoHistoryButton.SetActive(true);
            closePanelButton.SetActive(true);
            riddlePanel.SetActive(true);
        }
        if (this.gameObject.CompareTag("Close Btn"))
        {
            historyPanel.SetActive(false);
            gotoRiddleButton.SetActive(false);
            riddlePanel.SetActive(false);
            closePanelButton.SetActive(false);
            mainInfoPanel.SetActive(false);
        }
        if (this.gameObject.CompareTag("Goto History Btn"))
        {
            historyPanel.SetActive(true);
            gotoRiddleButton.SetActive(true);

            riddlePanel.SetActive(false);
            closePanelButton.SetActive(false);
            gotoHistoryButton.SetActive(false);
        }
    }
}
