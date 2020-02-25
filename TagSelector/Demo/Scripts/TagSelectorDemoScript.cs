// ------------------------------------------- //
// Author  : William Whitehouse / WSWhitehouse //
// GitHub  : github.com/WSWhitehouse           //
// Created : 25/02/2020                        //
// Edited  : 25/02/2020                        // 
// ------------------------------------------- //

using UnityEngine;

namespace WSWhitehouse.TagSelector.Demo
{
    public class TagSelectorDemoScript : MonoBehaviour
    {
        [TagSelector] public string tagOne;

        [TagSelector(UseDefaultTagFieldDrawer = true)]
        public string tagTwo;
    }
}