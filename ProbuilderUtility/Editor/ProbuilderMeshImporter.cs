#if INCLUDE_PROBUILDER
using UnityEngine;
using UnityEditor;
using UnityEngine.ProBuilder;

namespace UnityUtilityEditor
{
    public class ProbuilderMeshImporter
    {
        [MenuItem(UnityEditorUtility.menuItemPath + "Generate mesh asset from selected gameObject")]
        private static void GenerateMeshAssetFromSelectedGameObject()
        {
            GameObject selected = Selection.activeGameObject;

            if (selected == null)
            {
                Debug.Log("There are no selected gameObject.");
                return;
            }
            if (selected.TryGetComponent(out ProBuilderMesh proBuilderMesh) == false)
            {
                Debug.Log("There are no probuilder mesh in selected gameObject.");
                return;
            }

            if (proBuilderMesh.TryGetComponent(out MeshFilter meshFilter))
            {
                Mesh mesh = meshFilter.sharedMesh;

                AssetDatabase.CreateAsset(Object.Instantiate(mesh), "Assets/Mesh.asset");
                AssetDatabase.SaveAssets();
            }
        }
    }
}
#endif