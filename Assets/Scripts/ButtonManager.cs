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
        if (this.gameObject.name == "Click Btn")
        {
            mainInfoPanel.SetActive(true);
            historyPanel.SetActive(true);
            gotoRiddleButton.SetActive(true);

            riddlePanel.SetActive(false);
            gotoHistoryButton.SetActive(false);
            closePanelButton.SetActive(false);
        }
        if (this.gameObject.name == "Goto riddle button")
        {
            historyPanel.SetActive(false);
            gotoRiddleButton.SetActive(false);

            gotoHistoryButton.SetActive(true);
            closePanelButton.SetActive(true);
            riddlePanel.SetActive(true);
        }
        if (this.gameObject.name == "Close panel button")
        {
            historyPanel.SetActive(false);
            gotoRiddleButton.SetActive(false);
            riddlePanel.SetActive(false);
            closePanelButton.SetActive(false);
            mainInfoPanel.SetActive(false);
        }
        if (this.gameObject.name == "goto history button")
        {
            historyPanel.SetActive(true);
            gotoRiddleButton.SetActive(true);

            riddlePanel.SetActive(false);
            closePanelButton.SetActive(false);
            gotoHistoryButton.SetActive(false);
        }
    }
}
