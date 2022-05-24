using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeficiencySelector : MonoBehaviour
{
    public List<Image> outlines;
    public List<Image> selectedImages = new List<Image>();
    public List<Image> rgDefs;
    public GameObject rgDefIconPrefab;
    public Transform defsParent;
    private bool selectedImgsChanged = false;

    public void ToggleSelection(int index)
    {
        selectedImgsChanged = true;
        Image border = outlines[index];
        border.enabled = !border.enabled;

        if (border.enabled)
            selectedImages.Add(border);
        else
            selectedImages.Remove(border);
    }

    public void UnselectAllDefs()
    {
        foreach (var outline in outlines)
        {
            outline.enabled = false;
            if(selectedImages.Contains(outline))
                selectedImages.Remove(outline);
        }
    }

    public void ClearDefs()
    {
        for (int i = 0; i < rgDefs.Count; i++)
        {
            var child = defsParent.GetChild(i).gameObject;
            var childImg = child.GetComponent<Image>();

            Destroy(child);
        }

        rgDefs.Clear();
    }

    public void CloseDeficiencyPanel()
    {
        if (!selectedImgsChanged)
            return;

        ClearDefs();

        foreach (var defImg in selectedImages)
        {
            var newDefImg = Instantiate(rgDefIconPrefab, defsParent);
            var defImgComponent = newDefImg.GetComponent<Image>();
            defImgComponent.sprite = defImg.gameObject.transform.GetChild(0).GetComponent<Image>().sprite;
            rgDefs.Add(defImgComponent);
        }
        selectedImgsChanged = false;
    }
}
