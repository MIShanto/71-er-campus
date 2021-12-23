using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] Animator my_animator;
    [SerializeField] GameObject mainInfoPanel;
    [SerializeField] GameObject historyPanel;
    [SerializeField] GameObject riddlePanel;
    [SerializeField] GameObject gotoRiddleButton;
    [SerializeField] GameObject gotoHistoryButton;
    [SerializeField] GameObject closePanelButton;

    [SerializeField] GameObject[] spotImageHolders;


    private void OnMouseDown()
    {

        if (this.gameObject.CompareTag("Click Btn"))
        {
            //mainInfoPanel.SetActive(true);
            my_animator.Play("open_panel");
            my_animator.Play("history_panel_swap2");

            historyPanel.SetActive(true);
            gotoRiddleButton.SetActive(true);

            riddlePanel.SetActive(false);
            gotoHistoryButton.SetActive(false);
            closePanelButton.SetActive(false);

            
        }
        if (this.gameObject.CompareTag("Goto Riddle Btn"))
        {
            //historyPanel.SetActive(false);
            my_animator.Play("history_panel_swap");
            my_animator.Play("riddle_panel_come");

            gotoRiddleButton.SetActive(false);

            gotoHistoryButton.SetActive(true);
            closePanelButton.SetActive(true);
            riddlePanel.SetActive(true);
        }
        if (this.gameObject.CompareTag("Close Btn"))
        {

            my_animator.Play("riddle_panel_close");

            my_animator.Play("close_panel");

            historyPanel.SetActive(false);
            gotoRiddleButton.SetActive(false);
            riddlePanel.SetActive(false);
            closePanelButton.SetActive(false);
            //mainInfoPanel.SetActive(false);

            
        }
        if (this.gameObject.CompareTag("Goto History Btn"))
        {
            //historyPanel.SetActive(true);

            my_animator.Play("riddle_panel_close");
            my_animator.Play("history_panel_swap2");
            gotoRiddleButton.SetActive(true);

            riddlePanel.SetActive(false);
            closePanelButton.SetActive(false);
            gotoHistoryButton.SetActive(false);
        }
    }
}
