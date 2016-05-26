using UnityEngine;
using System.Collections;

public class DialogGameSceneExample : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        //If press left mouse button and no dialog is being shown, call for a popup dialog
        //Set the Yes callback to call the TurnGreen method, and the No callback to call the TurnRed method.
	    if (Input.GetKeyDown("space") && !DialogManager.showingDialog)
	    {
	        DialogManager.PopUpDialog("Troubled Man",
                "My wife here wants to spend money on a showerhead that we could barely even afford just because she saw it in an infomercial.\nI just lost my job, and she chooses now to be environmentally friendly?\n I mean, I’m all about saving the Earth and whatnot, but I’m not about to go spend money that I don’t even have. You’re a water conservation person, right?\n What should I do?",
                DialogManager.DialogType.YesNoDialog,
                TurnGreen,
                TurnRed);
	    }

        //If press right mouse button and no dialog is being shown, call for a popup dialog
        //Set the ok callback to call TurnBlue method.
        if (Input.GetMouseButtonDown(1) && !DialogManager.showingDialog)
        {
            DialogManager.PopUpDialog("Wow this happened!",
                "It really happened! Wow! Much dialog!",
                DialogManager.DialogType.OkDialog,
                TurnBlue);
        }
    }

    void TurnBlue()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.blue;
    }

    void TurnGreen()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.green;
    }

    void TurnRed()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
}
