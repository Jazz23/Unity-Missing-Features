using UnityEngine;

namespace KevinCastejon.MissingFeatures.MissingAttributes
{
    /// <summary>
    /// Shows or hides the current property on the inspector based on an external serialized bool property value.
    /// </summary>
    public class ShowPropIfAttribute : PropertyAttribute
    {
        public readonly string boolSerializedPropertyName;
        public readonly bool isTrue;

        /// <summary>
        /// Shows or hides the current property on the inspector based on an external serialized bool property value.
        /// </summary>
        /// <param name="boolSerializedPropertyName">The name of the external serialized bool property</param>
        /// <param name="isTrue">Wether to check if the external serialized bool property value should be true or false in order to show the current property into the inspector</param>
        public ShowPropIfAttribute(string boolSerializedPropertyName, bool isTrue = true)
        {
            this.boolSerializedPropertyName = boolSerializedPropertyName;
            this.isTrue = isTrue;
        }
    } 
}